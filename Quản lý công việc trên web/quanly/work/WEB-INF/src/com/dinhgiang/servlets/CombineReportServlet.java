/**
 * @(#)CombineReportServlet.java    v.1.0   2003/07/18
 * Title:        Job Management Project<p>
 * Description:
 * Developed by:
 * 	Dinh Le Giang
 * Goals:
 * 	are the project to defend graduated for school out
 * Guided by:
 * 	Ts. Nguyen Thuc Hai<p>
 * Copyright:    Copyright (c) giangdl130@yahoo.com<p>
 */

package com.dinhgiang.servlets;

/* Servlet classes  */
import javax.servlet.ServletConfig;
import javax.servlet.ServletException;

/* HttpServlet classes  */
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/* IO classes  */
import java.io.PrintWriter;
import java.io.IOException;
import java.io.File;

/* Utility classes  */
import java.util.Enumeration;
/* SQL classes */
import java.sql.Connection;
import java.sql.SQLException;

/* Utility classes, my package */
import com.dinhgiang.beans.UploaderBean;
import com.dinhgiang.utils.DBResults;
import com.dinhgiang.utils.JobPool;
/**
 * This Servlet processes uploaded files for giving idea
 * @see com.dinhgiang.utils.FileUploader
 * @author Dinh Le Giang
 * @version 1.0 2 July 2003
 */
public class CombineReportServlet extends HttpServlet {

    //Initialize global variables
    public void init(ServletConfig config) throws ServletException {
        super.init(config);
    }

    //Process the HTTP Post request
    public void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        response.setContentType("text/html");
        PrintWriter out = new PrintWriter(response.getOutputStream());

        try {
            /*- blindly take it on faith this is a
                multipart/form-data request
             */

            /*- Contruct a FileUploaderBean to help write and
                read the information. Pass in the request, a directory
                to save files to, and the maximum POST size we should attemp
                to handle. Here we (rudely) write to the server root and
                impose 2 MB limit.
             */
            // khong nhan biet
            //String reId = request.getParameter("reportID");
            //String fullName = request.getParameter("fullName");

	    UploaderBean upload = UploaderBean.getInstance(request);
            String sql = upload.makeInsertSQL("BaoCaoTongHop");
            String [] str = upload.makeSQLStatement();
            Connection conPool = JobPool.getInstance().getConnection();

            int rowAffected = DBResults.executeUpdate(conPool, sql);
            for (int i = 0; i < str.length; i++) {
                if (str[i] == null) {
                    break;
                }
                rowAffected = DBResults.executeUpdate(conPool, str[i]);
            }

            out.println("<html>");
            out.println("<head><title>Given Idea</title></head>");
            out.println("<body bgcolor=\"#FFFFFF\" text=\"#000099\">");
            out.println("<h2><font color=\"#AA0000\">You uploaded a file: </font></h2>");
            Enumeration files = upload.getFileNames();
            while (files.hasMoreElements()) {
                String name = (String) files.nextElement();

                String filename = upload.getTrulyFileName(name);
                String type = upload.getContentType(name);
                File f = upload.getFile(name);
                out.print("<ul><li> File name: " + filename + "</li>");
                out.print("<li> Type: " + type + "</li>");
                if (f != null) {
                    out.print("<li> Length (file size): " + f.length() + " Bytes</li>");
                    out.print("<li>Change Byte (division 1024): " + (f.length() / 1024) + " KB</li>");
                }
                out.print("</ul>");
		out.print("\r\n");
            }
            out.println("</body></html>");
            out.close();
        }
        catch (NullPointerException ex) {
            response.sendRedirect("../html/failFileUpload.html");
        }
        catch (IOException ex) {
            response.sendRedirect("../html/failFileUpload.html");
        }
        catch (SQLException ex) {
            response.sendRedirect("../html/failFileUpload.html");
        }
    }
}
