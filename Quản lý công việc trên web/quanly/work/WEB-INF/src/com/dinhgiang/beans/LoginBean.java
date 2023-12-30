/**
 * @(#)LoginBean.java    v.1.0   2003/07/13
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
package com.dinhgiang.beans;

/* Import java & javax classes for use */
import java.sql.Connection;
import java.sql.Statement;
import java.sql.ResultSet;
import java.sql.SQLException;
/*import javax.servlet.http.HttpSession;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.ServletRequest;*/

/* Import my classes for use */
import com.dinhgiang.utils.JobPool;

/**
 * This bean uses to store any login information.
 *
 * @author Dinh Le Giang
 * @version 1.0 13 July 2003
 */
public class LoginBean {

    private String username;
    private String password;

    public LoginBean() {
        username = "";
        password = "";
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public UserBean authenticate(Connection con) throws SQLException{

        String sql = "select magroup, manv from NhanVien where UserName='"
                     + username + "' and Password='" + password + "'";
        Statement stmt = con.createStatement();
        ResultSet rs = stmt.executeQuery(sql);
        if (rs.next()) {
            return new UserBean(username, password, rs.getString(1), rs.getString(2));
        }
        else {
            return null;
        }
    }
}