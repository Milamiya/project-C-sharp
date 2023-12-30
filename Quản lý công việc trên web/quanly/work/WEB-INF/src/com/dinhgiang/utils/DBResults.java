/**
 * @(#)DBResults.java    v.1.0   2003/07/08
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
package com.dinhgiang.utils;

/* Import Java classes for use */
import java.sql.Connection;
import java.sql.SQLException;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.ResultSetMetaData;
import java.sql.DatabaseMetaData;

/**
 * Class to store completed results of a JDBC Query.
 * Differs from a ResultSet in several ways:
 * <ul>
 *  <li>ResultSet doesn't necessarily have all the data;
 *       reconnection to database occurs as you ask for
 *       later rows.
 *  </li>
 *  <li>This class stores results as strings, in arrays.
 *  </li>
 *  <li>This class includes DatabaseMetaData (database product
 *       name and version) and ResultSetMetaData
 *       (the column names).
 *  </li>
 *  <li>This class has a toHTMLTable method that turns
 *       the results into a long string corresponding to
 *       an HTML table.
 *  </li>
 *  <li>This class has a toXML method that turns
 *       the results into a long string from a table.
 *  </li>
 * </ul>
 * <p>
 * @author Dinh Le Giang
 * @version 1.0 6 July 2001
 * </p>
 */
public class DBResults {
    /**
     * Output the results as an HTML table, with
     * the column names as headings and the rest of
     * the results filling regular data cells.
     */
    public static String transferHTMLTable(Connection con, String sql,
                            int border, String headingColor) throws SQLException {
        try{
            Statement stmt = con.createStatement();
            ResultSet rs = stmt.executeQuery(sql);
            ResultSetMetaData rsMetaData = rs.getMetaData();

            StringBuffer buffer =
                new StringBuffer("<table border=\"" + border + "\">\n");
            if (headingColor != null) {
                buffer.append("\t<tr bgcolor=\"" + headingColor + "\">\n");
            }
            else {
                buffer.append("\t<tr>\n");
            }

            int colCount = rsMetaData.getColumnCount() + 1;

            buffer.append("\t\t<th>STT</th>\n");
            for(int col = 1; col < colCount; col++) {
                buffer.append("\t\t<th>" + rsMetaData.getColumnName(col) + "</th>\n");
            }
            buffer.append("\t</tr>\n");
            while (rs.next()) {
                buffer.append("\t<tr>\n");
                buffer.append("\t\t<td>" + rs.getRow() + "</td>\n");
                for(int col = 1; col < colCount; col++) {
                    buffer.append("\t\t<td>" + rs.getString(col) + "</td>\n");
                }
                buffer.append("\t</tr>\n");
            }
            rs.close();
            stmt.close();
            buffer.append("</table>");

            return(buffer.toString());
        }
        catch (SQLException ex) {
            throw new SQLException("Error when transforming HTML table");
        }
    }

    /**
     * Transfer two or more tables from SQL statement to XML format
     */
    public static String transferSpecialXML(Connection con,
                        String sql) throws SQLException {
        try {
            ResultSet rs = executeQuery(con, sql);
            if (rs.next() == false) {
                return null;
            }
            ResultSetMetaData rsMetaData = rs.getMetaData();

            StringBuffer buffer = new StringBuffer("<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>\r\n");
            buffer.append("<congviec>");

            String table = rsMetaData.getTableName(1).toLowerCase();
            String table1 = rsMetaData.getTableName(2).toLowerCase();
            String oldValue = "";
            int row = 1;
            boolean done = true;
            while (done) {
                String value = rs.getString(1);
                if ( !value.equals(oldValue) ) {
                    if ( !oldValue.equals("") ) {
                        buffer.append("\t\t<report-row no=\"" + (row - 1) + "\" />\r\n");
                        row = 1;
                        buffer.append("\t</" + table + ">\r\n");
                    }

                    buffer.append("\r\n\t<" + table + " name=\"" + value + "\">\r\n");
                    oldValue = value;
                }
                buffer.append("\t\t<" + table1 + " id=\"" + row + "\" ngay=\""
                    + rs.getString(2) + "\" tiendo=\""
                    + rs.getString(3) + "\" ghichu=\""
                    + rs.getString(4) +"\" />\r\n");
                row++;
                if (rs.next() == false) {
                    done = false;
                }
            }
            buffer.append("\t\t<report-row no=\"" + (row - 1) + "\" />\r\n");
            buffer.append("\t</" + table + ">\r\n");
            buffer.append("</congviec>");

            rs.close();

            return buffer.toString();
        }
        catch (SQLException ex) {
            throw new SQLException("Error when transfering XML format.");
        }
    }

    /**
     * Output the results as an XML format.
     * There are three methods (overload) for process
     * <ul>
     *  <li> The method transferXML() takes non-argument,
     *       transform to default
     *  </li>
     *  <li> The method transferXML() takes a argument,
     *       @param encoding this is a character set.
     *  </li>
     *  <li> The method transferXML() takes two arguments,
     *       @param encoding stytesheet encoding is
     *       a character set stytesheet is url stytesheet.
     *  </li>
     * </ul>
     * They return a long string.
     */
     public static String transferXML(Connection con,
                        String sql) throws SQLException {
        try {
            ResultSet rs = executeQuery(con, sql);
            if (rs.next() == false) {
                return null;
            }
            ResultSetMetaData rsMetaData = rs.getMetaData();

            StringBuffer buffer = new StringBuffer("<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>\r\n");
            buffer.append("<congviec>");

            String table = rsMetaData.getTableName(1).toLowerCase();

            int n = rsMetaData.getColumnCount() + 1;
            boolean done = true;
            while (done) {
                buffer.append("\t<" + table + " stt=\"" + rs.getRow() + "\">\r\n");
                for (int colCount = 1; colCount < n; colCount++) {
                    String fieldName = rsMetaData.getColumnName(colCount);
                    buffer.append(getElement(fieldName.toLowerCase(),
                                      rs.getString(fieldName)));
                }
                buffer.append("\t</" + table + ">\r\n");

                if (rs.next() == false) {
                    done = false;
                }
            }
            buffer.append("</congviec>");

            rs.close();

            return buffer.toString();
        }
        catch (SQLException ex) {
            throw new SQLException("Error when transfering XML format." + sql);
        }
    }

    public static String transferXML(Connection con, String sql,
                                    String database) throws SQLException {
        try{
            ResultSet rs = executeQuery(con, sql);
            if (rs.next() == false) {
                return null;
            }

            ResultSetMetaData rsMetaData = rs.getMetaData();

            StringBuffer buffer = new StringBuffer("<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>\r\n");
            buffer.append("<" + database.toLowerCase() + ">\r\n");

            String table = rsMetaData.getTableName(1).toLowerCase();

            int n = rsMetaData.getColumnCount() + 1;
            boolean done = true;
            while (done) {
                buffer.append("\t<" + table + " stt=\"" + rs.getRow() + "\">\r\n");
                for (int colCount = 1; colCount < n; colCount++) {
                    String fieldName = rsMetaData.getColumnName(colCount);
                    buffer.append(getElement(fieldName.toLowerCase(),
                                      rs.getString(fieldName)));
                }
                buffer.append("\t</" + table + ">\r\n");
                if (rs.next() == false) {
                    done = false;
                }
            }
            buffer.append("</" + database.toLowerCase() + ">");

            rs.close();

            return buffer.toString();
        }
        catch (SQLException ex) {
            throw new SQLException("Error when transfering XML format.");
        }
    }

    public static String transferXML(Connection con, String sql,
                    String database, String encoding) throws SQLException {
        try{
            ResultSet rs = executeQuery(con, sql);
            if (rs.next() == false) {
                return null;
            }
            ResultSetMetaData rsMetaData = rs.getMetaData();

            StringBuffer buffer = new StringBuffer("<?xml version=\"1.0\" encoding=\"" + encoding + "\"?>\r\n");
            buffer.append("<" + database.toLowerCase() + ">\r\n");

            String table = rsMetaData.getTableName(1).toLowerCase();

            int n = rsMetaData.getColumnCount() + 1;
            boolean done = true;
            while (done) {
                buffer.append("\t<" + table + " stt=\"" + rs.getRow() + "\">\r\n");
                for (int colCount = 1; colCount < n; colCount++) {
                    String fieldName = rsMetaData.getColumnName(colCount);
                    buffer.append(getElement(fieldName.toLowerCase(),
                                      rs.getString(fieldName)));
                }
                buffer.append("\t</" + table + ">\r\n");
                if (rs.next() == false) {
                    done = false;
                }
            }
            buffer.append("</" + database.toLowerCase() + ">");

            rs.close();

            return buffer.toString();
        }
        catch (SQLException ex) {
            throw new SQLException("Error when transfering XML format.");
        }
    }

    /**
     * Execute INSERT & UPDATE statement. Return 1
     * if performing seccessfully, otherwise failed.
     */
    public static int executeUpdate(Connection con,
                                        String updateSQL)
                                        throws SQLException {
        try {
            Statement stmt = con.createStatement();
            int rowAffected = stmt.executeUpdate(updateSQL);
            return rowAffected;
        }
        catch(SQLException ex) {
            throw new SQLException(ex.toString() + ". Error when executing INSERT OR UPDATE statement.\n" + updateSQL);
        }
    }

    /**
     * Execute SELECT statement. Return ResultSet
     * if performing seccessfully, null otherwise.
     */
    public static ResultSet executeQuery(Connection con,
                                        String selectSQL)
                                        throws SQLException {
        try {
            Statement stmt = con.createStatement();
            ResultSet rs = stmt.executeQuery(selectSQL);
            return rs;
        }
        catch(NullPointerException ex) {
            throw new NullPointerException("ResultSet return null.\r\n");
        }
        catch(SQLException ex) {
            throw new SQLException(ex.toString() + ". Error when executing SELECT statement.\r\n" + selectSQL);
        }
    }

    /**
     * Execute the extension queries in mySQL. Return value greater than 1
     * if performing seccessfully, otherwise failed.
     */
    public static int performExtension(Connection con,
                                        String loadSQL)
                                        throws SQLException {
        try {
            Statement stmt = con.createStatement();
            int rowAffected = stmt.executeUpdate(loadSQL);
            return rowAffected;
        }
        catch(SQLException ex) {
            return 0;
        }
    }

    /*- Create a element including content */
    private static String getElement(String fieldName, String content) {
        String element = "\t\t<" + fieldName + ">" + content
                       + "</" + fieldName + ">\n";
        return element;
    }
}