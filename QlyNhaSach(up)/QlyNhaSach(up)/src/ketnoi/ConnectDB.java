package ketnoi;

import java.sql.*;
import javax.swing.JOptionPane;

public class ConnectDB{

	static Connection conn = null;
	static String conString = "jdbc:mysql://localhost:3306/qly_nhasach";
	static String driver = "com.mysql.jdbc.Driver";
	static String userName = "root";
	static String password = "hoanganh11";
	
	public static Connection getConnection(){
		try{
			
			Class.forName(driver).newInstance();
			conn = DriverManager.getConnection(conString, userName,password);
			
		}catch (ClassNotFoundException | InstantiationException | IllegalAccessException | SQLException e) {
            JOptionPane.showMessageDialog(null, "Không thể kết nối với CSDL");
        }
		return conn;
	}
}

