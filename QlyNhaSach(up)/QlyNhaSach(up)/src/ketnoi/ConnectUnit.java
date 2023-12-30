package ketnoi;


import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.sql.Types;
import java.util.HashMap;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.sql.*;

/**
 *
 * @author A7
 */
public class ConnectUnit {

    /**
     * @return the _connectionReport
     */
    public static Connection getConnectionReport() {
        return _connectionReport;
    }

    /**
     * @param aConnectionReport the _connectionReport to set
     */
    public static void setConnectionReport(Connection aConnectionReport) {
        _connectionReport = aConnectionReport;
    }

    //Biến kết nối cơ bản
    public MySQLConnect _connect;
    private static Connection _connectionReport;
    // Hàm hỗ trợ Select CSDL
    // SELECT * FORM TableName WHERE Condition ORDER BY OrderBy;
    public ResultSet Select(String TableName, String Condition,String OrderBy) throws Exception
    {
        // Khai báo biến StringBuilder để tạo chuỗi Select.
        StringBuilder query = new StringBuilder( "SELECT * FROM " + TableName);
        // Đưa câu lệnh điều kiện vào trong câu query
        this.AddCondition(query, Condition);
        // Đưa câu lệnh Order vào câu query
        this.AddOrderBy(query, OrderBy);
        // Chèn ký tự ';' vào cuối dòng lệnh của để cách các câu lệnh.
        query.append(";");
        // Thực thi câu query và trả kết quả ra ngoài
        return _connect.excuteQuery(query.toString());
    }

    // Hàm over load Select giảm OdrderBy parameter
    public ResultSet Select(String TableName, String Condition) throws Exception
    {
        return this.Select(TableName, Condition, null);
    }
    
    // Hàm over load Select giảm Condition paramter
     public ResultSet Select(String TableName) throws Exception
     {
        return this.Select(TableName, null);
    }

     // Hàm thêm điều kiện vào query
     private void AddCondition(StringBuilder query, String Condition)
     {
         // Kiểm tra nếu condiotn khác null
         if(Condition!=null)
            query.append(" WHERE ").append(Condition);
    }

     // Hàm thêm OrderBy vào query
    private void AddOrderBy(StringBuilder query,String OrderBy)
    {
        // Kiểm tra OrderBy khác null
        if(OrderBy!=null)
            query.append(" ORDER BY ").append(OrderBy);
    }

    // Hàm hỗ trợ Insert xuống CSDL.
    // INSERT INTO TableName (columnName...) VALUES (column Values...);
    public boolean Insert(String TableName, HashMap<String,Object> ColumnValues) throws Exception
    {
        // Khai báo biến StringBuilder để tạo chuỗi Select.
        StringBuilder query =  new StringBuilder("INSERT INTO " + TableName);
        // Khai báo biến StringBuilder để tạo chuỗi Column Values.
        StringBuilder valueInsert = new StringBuilder();

        query.append("(");
        // Duyệt và đưa thông tin tên cột và giá trị của cột vào câu query
        for(String key : ColumnValues.keySet())
        {
            query.append(key).append(",");
            valueInsert.append("'").append(ColumnValues.get(key).toString()).append("' ,");
        }
        // Cắt bớt ký tự ',' cuối câu
        query = query.delete(query.length()-1, query.length());
        valueInsert = valueInsert.delete(valueInsert.length()-1, valueInsert.length());

        // Đưa giá trị của cột vào câu query
        query.append(") VALUES(").append(valueInsert.toString()).append(")");
        // Chèn ký tự ';' vào cuối dòng lệnh của để cách các câu lệnh.
        query.append(";");
        // Thực thi câu query và trả kết quả ra ngoài
        return this._connect.executeUpdate(query.toString()) > 0;
    }

    // Hàm hỗ trợ Update CSDL
    // UPDATE TableName SET ColumnName = ColumnValue WHERE Condiotion;
    public boolean Update(String TableName, HashMap<String,Object> ColumnValues, String Condition) throws Exception 
    {
        // Khai báo biến StringBuilder để tạo chuỗi Select.
        StringBuilder query = new StringBuilder("UPDATE " + TableName + " SET ");

        // Duyệt và đưa thông tin tên cột và giá trị của cột vào câu query
        for(String key : ColumnValues.keySet())
        {
            query.append(key).append(" = '").append(ColumnValues.get(key).toString()).append("',");
        }
        // Cắt bớt ký tự ',' cuối câu
        query = query.delete(query.length()-1, query.length());
        // Đưa câu lệnh điều kiện vào trong câu query
        this.AddCondition(query, Condition);
        // Chèn ký tự ';' vào cuối dòng lệnh của để cách các câu lệnh.
        query.append(";");
        // Thực thi câu query và trả kết quả ra ngoài
        return this._connect.executeUpdate(query.toString())> 0 ;
    }

    // Hàm hỗ trợ DELETE trong CSDL
    // DELETE FROM TableName WHERE Condition.
    public boolean Delete(String TableName,String Condition) throws Exception
    {
        // Khai báo biến StringBuilder để tạo chuỗi Select.
        StringBuilder query = new StringBuilder( "DELETE FROM " + TableName);
        // Đưa câu lệnh điều kiện vào trong câu query
        this.AddCondition(query, Condition);
        // Chèn ký tự ';' vào cuối dòng lệnh của để cách các câu lệnh.
        query.append(";");
        // Thực thi câu query và trả kết quả ra ngoài
        return this._connect.executeUpdate(query.toString()) > 0;
    }

    // Đếm số cột trong Result select từ CSDL.
    public static int getColumnCount(ResultSet result) throws SQLException
    {
        // Lất số lượng cợt từ MetaData của Result.
        return result.getMetaData().getColumnCount();
    }

    // Hàm lấy danh sách tên cột trong Result select từ CSDL.
    public static String[]getColumnName(ResultSet result) throws SQLException
    {
        // Lấy ResultSetMetaDate từ Result
        ResultSetMetaData rsMetaData = (ResultSetMetaData)result.getMetaData();
        // Lấy số lượng cột trong Result.
        int ColumnCount = rsMetaData.getColumnCount();
        // Khai báo danh sách các cột.
        String[] list = new String[ColumnCount];
        // Duyệt các cột
        for(int i=0;i<ColumnCount;i++)
            // Lấy ten đưa vào danh sách
            list[i]=rsMetaData.getColumnName(i);
        // Trả danh sách ra ngoài.
        return list;
    }

    // Đóng kết nối.
    public void Close() throws SQLException
    {
        this._connect.Close();}

    // Hàm khởi tạo với các thông số kết nối DataBase Server.
    public ConnectUnit(String host,int Port, String user,String pass,String db) 
    {
            this._connect = new MySQLConnect(host,Port, user,pass,db);
    }

    public boolean Connect()
    {
        try 
        {
            setConnectionReport(_connect.getConnect());
            return true;
        } 
        catch (Exception ex) 
        {
            Logger.getLogger(ConnectUnit.class.getName()).log(Level.SEVERE, null, ex);
            return false;
        }
    }
    public void Update(String sach, HashMap<String, Object> map) 
    {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    class connect {

        public connect() {
        }
    }
    
   
}
