package ketnoi;

import java.sql.*;

/**
 *
 * @author A7
 */
public class MySQLConnect {
    String _host = "localhost";
    int _port = 3306;
    String _userName = "root";
    String _pass = "";
    String _dataBase = "qly_nhasach";

    Connection _connect = null;
    ResultSet _result = null;
    Statement _statement = null;

    // Hàm khởi tạo và truyền thông tin của _dataBase Server.
    public MySQLConnect(String Host, int Port,
            String UserName,
            String Password,
            String DataBase){
        this._host = Host;
        this._port = Port; 
        this._userName = UserName;
        this._pass = Password;
        this._dataBase = DataBase;
    }

    // Hàm kiểm tra xem Driver connect MySQL đã sẵn sàng hay chưa.
    protected void driverTest () throws Exception{
        try {
            //Kiểm tra Class Name.
            Class.forName("org.gjt.mm.mysql.Driver");
        }
        // Nếu chưa tồng tại thì mém lỗi ra ngoài.
        catch (java.lang.ClassNotFoundException e) 
        {
                throw new Exception("Không tìm thấy Driver MySQL JDBC...");
        } 
    }

    // Hàm lấy Connecttion
    protected Connection getConnect() throws Exception {
       // Nếu connetion null thì khởi tạo mới.
        if(this._connect==null){
            // Kiểm tra Driver
           driverTest();
            String url = "jdbc:mysql://" + this._host + ":3306/" + this._dataBase;
            try 
            {
                // Tạo Connection thông qua Url
               // SQLServerDataSource ds = new SQLServerDataSource();
                
            //    ds.setUser(this._userName);
                //ds.setPassword(this._pass);
                //ds.setServerName(this._host);
               // ds.setPortNumber(this._port);
               // ds.setDatabaseName(this._dataBase);
                
                this._connect = DriverManager.getConnection(url, this._userName, this._pass );
            }
            // Nếu không thành công ném lỗi ra ngoài.
            catch (java.sql.SQLException e) 
            {
                throw new Exception("Không thể kết nối đến DataBase Server...");
            }
       }
        // Trả connection ra ngoài.
        return this._connect;
    }
    
    // Đóng kết nối CSDL
    public void Close() throws SQLException {
        if (this._result != null) {
            if (!this._result.isClosed()) {
                this._result.close();
            }
            this._result = null;
        }
        
        if (this._statement != null) {
            if (!this._statement.isClosed()) {
                this._statement.close();
            }
            this._statement = null;
        }
        
        if (this._connect != null) {
            if (!this._connect.isClosed()) {
                this._connect.close();
            }
            this._connect = null;
        }
    }
    
    // Thực hiện câu truy vấn
    public ResultSet excuteQuery(String Query) throws Exception {
        try {
            // Thực thi câu lệnh.
            this._result = getStatement().executeQuery(Query);
        } // Nếu không thành công ném lỗi ra ngoài.
        catch (Exception e) {
            throw new Exception("Lỗi: " + e.getMessage() + " - " + Query);
        }
        return this._result;
    }

    // Thực hiện câu lệnh Update
    public int executeUpdate(String Query) throws Exception {
        //Khai báo biến int lưu trữ kết quả tình trạng thực thi câu lệnh Query.
        int res = Integer.MIN_VALUE;
        try {
            //Thực thi câu lệnh.
            res = getStatement().executeUpdate(Query);
        } //Nếu không thành công ném lỗi ra ngoài.
        catch (Exception e) {
            throw new Exception("Lỗi: " + e.getMessage() + " - " + Query);
        } finally {
            //Đóng kết nối.
            this.Close();
        }
        return res;
    }
    
    //
    public Statement getStatement() throws Exception {
        // Kiểm tra _statement nếu = null hoặc đã đóng.
        if (this._statement == null ? true : this._statement.isClosed()) {
            // Khởi tạo một _statement mới.
            this._statement = this.getConnect().createStatement();
        }
        return this._statement;
    }

}

