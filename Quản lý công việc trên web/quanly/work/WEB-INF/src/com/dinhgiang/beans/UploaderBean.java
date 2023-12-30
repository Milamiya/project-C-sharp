/**
 * @(#)UploaderBean.java    v.1.0   2003/07/24
 * Title:        Job Management Project<p>
 * Description:
 * Developed by:
 * 	Dinh Le Giang
 * Goals:
 * 	are the project to defend graduated for school out
 * Guided by:
 * 	Ts. Nguyen Thuc Hai <p>
 * Copyright:    Copyright (c) giangdl130@yahoo.com<p>
 */

package com.dinhgiang.beans;

/* HttpServlet classes  */
import javax.servlet.http.HttpServletRequest;

/* IO classes  */
import java.io.IOException;
import java.io.File;

/* Utility classes  */
import java.util.Enumeration;

/* SQL classes  */
import java.sql.Connection;
import java.sql.SQLException;

/* My classes */
import com.dinhgiang.utils.DBResults;

/**
 * This bean uses the following classes: FileUploaderBean,
 * UploadedFileBean, DBResults.
 * It uses the classes to save one or more files from a client request
 * and then stores their into database server.
 *
 * @see com.dinhgiang.beans.FileUploaderBean
 * @see com.dinhgiang.beans.UploadedFileBean
 * @see com.dinhgiang.utils.DBResults
 * @author Dinh Le Giang
 * @version 1.0 24 July 2003
 */
public class UploaderBean extends FileUploaderBean {
    /** Member data */
    private static UploaderBean upload = null;

    /**
     * Constructor default.
     */
    public UploaderBean() {

    }

    /** Process the POST request from client.
     *  <p>
     *  Blindly take it on faith this is a
     *  multipart/form-data request. </p>
     *  <p>
     *  Contruct a FileUploaderBean to help write and
     *  read the information. Pass in the request, a directory
     *  to save files to, and the maximum POST size we should attemp
     *  to handle. Here we (rudely) write to the server root and
     *  impose 2 MB limit.
     *  <p>
     */
    private UploaderBean(HttpServletRequest request) throws IOException {
            super(request,
                  "c:/jbuilder4/tomcat/webapps/work/uploadfiles", // The root folder is jakarta-tomcat\bin
                  2 * 1024 * 1024); //../webapps/work/uploadfiles
            //upload.readRequest(); // save uploaded files
    }

    /** Return a instance of UploaderBean form HTTP POST reques */
    public static UploaderBean getInstance(HttpServletRequest request)
                        throws IOException{
        try {
            upload = new UploaderBean(request);
            upload.readRequest();
            return upload;
        }
        catch(IOException ex) {
            return null;
        }
    }

    /* Create a SQL statement array from parameters in the uploaded files */
    public String[] makeSQLStatement() {
        int i = 0;
        String[] sqlStatements = new String[10];

        Enumeration files = upload.getFileNames();
        while (files.hasMoreElements()) {
            String name = (String) files.nextElement();
            String filename = upload.getTrulyFileName(name);
            String savedFile = upload.getSavedFileName(name);
            String type = upload.getContentType(name);
            File f = upload.getFile(name);
            long size = 0;
            if (f != null) {
                size = f.length();
            }
            sqlStatements[i] = "insert into Files(mafile, mabc, tenfile, "
                             + "filesize, contenttype, ngay) values('" + savedFile
                             + "', '" + savedFile.substring(0, savedFile.indexOf("."))
                             + "', '" + filename + "', " + size + ", '" + type.substring(14) + "', now())";
            i++;
        }
        return sqlStatements;
    }

    /* Create a INSERT statement from multipart/form request */
    public String makeInsertSQL(String table) {
        String fields = table + "("; //BaoCaoNgay(
        String values = "values(";
        Enumeration params = upload.getParameterNames();
        while (params.hasMoreElements()) {
            String name = (String) params.nextElement();
            System.out.println(name);
            //if (!name.equals("subOK")) {
                String value = upload.getParameter(name);
                if (params.hasMoreElements()) {
                    fields += name + ",";
                    if (isNumber(value) == 0 || name.equals("manv")) { // String
                        values += "'" + value + "',";
                    }
                    else { // Number
                        values += value + ",";
                    }
                }
                else { // end of params
                    fields += name + ") ";
                    if (isNumber(value) == 0 || name.equals("manv")) {
                        values += "'" + value + "')";
                    }
                    else {
                        values += value + ")";
                    }
                }
            //}
        }
        String sql = "insert into " + fields + values;

        return sql;
    }

    /* Create a UPDATE statement from multipart/form request */
    public String makeUpdateSQL(String table) {
        String fields = " set ";
        String where = " where ";
        Enumeration params = upload.getParameterNames();
        while (params.hasMoreElements()) {
            String name = (String) params.nextElement();
            String value = upload.getParameter(name);
            if (name.startsWith("mabc")) {
                where += name + "='" + value + "'";
            }
            else {
                if (params.hasMoreElements()) {
                    if (isNumber(value) == 0) { // String
                        fields += name + "='" + value + "',";
                    }
                    else { // Number
                        fields += name + "=" + value + ",";
                    }
                }
                else { // end of params
                    if (isNumber(value) == 0) {
                        fields += name + "='" + value + "'";
                    }
                    else {
                        fields += name + "=" + value;
                    }
                }
            }
        }
        String sql = "update " + table + fields + where;

        return sql;
    }
    private static int isNumber(String value) {
        int count = 0;
        for (int i = 0; i < value.length(); i++) {
            char c = value.charAt(i);
            if (c=='0' || c=='1' || c=='2' ||
                    c=='3' || c=='4' || c=='5' ||
                    c=='6' || c=='7' || c=='8' ||
                    c=='9' || c=='.' || c==',') {
                count++;
            }
            else {
                return 0;
            }
        }
        return count;
    }
}