<?xml version="1.0" encoding="ISO-8859-1"?>
<html xmlns="http://www.w3.org/TR/xhtml1/strict">
    <%@ page language="java"
             import="com.dinhgiang.utils.JobPool,
                     java.sql.Connection,
                     java.sql.ResultSet,
                     java.sql.SQLException,
                     com.dinhgiang.beans.UserBean,
                     com.dinhgiang.utils.DBResults"
             errorPage="error.jsp" %>
    <%--
        @author     : Dinh Le Giang
        @date       : August 30, 2003
        @description: Refresh Database.
     --%>
    <head>
        <title>Refresh Database</title>
        <link rel="stylesheet" href="../xslt/jobStyle.css" type="text/css" />
    </head>
    <body bgcolor="#FFFFFF" text="#000099">
<%!
    String xmlDoc = null;
    private int deleteData(Connection con, String begin, String end) throws SQLException{
        String[] tables = {"Files", "GopY", "BaoCaoNgay", "BaoCaoTongHop",
                  "DanhGia", "DeAn", "ThietLap", "Works", "PhanCong"};
        String where = " where ngay>='" + begin + "' and ngay<='" + end + "'";
        try {
            int i;
            for (i = 0; i < 9; i++) {
                if (tables[i].equals("PhanCong")) {
                    where = " where ngaykt>='" + begin + "' and ngaykt<='" + end + "'";
                }
                String sql = "delete from " + tables[i] + where;
                int affectedRow = DBResults.executeUpdate(con, sql);
            }
            return i;
        }
        catch(SQLException ex) {
            return 0;
        }
    }
%>
<%
    UserBean user = (UserBean) session.getAttribute("user");
    if (user != null) {

        Connection conPool = (Connection) session.getAttribute("conJobPool");
        if (conPool != null) {
	    String dbName = request.getParameter("dbName");
	    String start = request.getParameter("start");
	    String end = request.getParameter("end");
            String optRefresh = request.getParameter("refresh");
            String sql = null;
            int num = 0;
            try {
                String[] tables = {"GopY", "DeAn", "DanhGia", "Works", "PhanCong",
                                   "BaoCaoNgay", "BaoCaoTongHop", "Files", "ThietLap"};

                String createDataBase = "CREATE DATABASE IF NOT EXISTS " + dbName;
                int affectedRow = DBResults.executeUpdate(conPool, createDataBase);

                for (int i = 0; i < 9; i++) {
                    // Create a data file to restore a database if necessary.
                    sql = "select * into outfile '" + dbName + "/"+ tables[i] + "_Data.txt' from " + tables[i];
                    affectedRow = DBResults.performExtension(conPool, sql);
                }
            }
            finally { // it has errors or not, must perform
                int option = Integer.parseInt(optRefresh);
                switch(option) {
                    case 0: // from day to day
                        num = deleteData(conPool, start, end);
                        break;
                    case 1: // from month to month
                        String year = request.getParameter("year");
                        start = year + "-" + start + "-01";
                        end = year + "-" + end + "-31";
                        num = deleteData(conPool, start, end);
                        break;
                    case 2: // entirely year
                        String start1 = start + "-01" + "-01";
                        end = start + "-12" + "-31";
                        num = deleteData(conPool, start1, end);
                        break;
                }
            }
            if (num == 9) {
%>
	<h3><font face="VNI-Times" color="#AA0000">Baïn ñaõ laøm töôi(refresh) thaønh coâng</font></h3>
<%
	    }
	    else {
%>
        <h3><font face="VNI-Times" color="#AA0000">Teân cô sôû döõ lieäu môùi bò truøng.</font></h3>
        <%= dbName %>
<%
            }
        }
    }
%>
    </body>
</html>