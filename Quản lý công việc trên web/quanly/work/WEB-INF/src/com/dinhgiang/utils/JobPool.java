/**
 * @(#)JobPool.java    v.1.0   2003/07/13
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

/* Import Java classes for necessary */
import java.sql.SQLException;

/**
 * Creating a Singleton class to share connection pools.
 *
 * @author Dinh Le Giang
 * @version 1.0 13 July 2003
 */
public class JobPool extends ConnectionPool {
    private static JobPool jobPool = null;

    private JobPool(String driver, String url, String username,
                String password, int initCons, int maxCons,
                boolean waitIfBusy) throws SQLException {
        /* Call parent constructor */
        super(driver, url, username, password, initCons, maxCons, waitIfBusy);
    }

    public static JobPool getInstance()
                throws SQLException, NullPointerException {
        try {
            if (jobPool == null) {
                jobPool = getInstance("localhost", "CongViec", "", ""); // "root", "dinhgiang"
            }
	    return jobPool;
        }
        catch (NullPointerException ex) {
            throw new NullPointerException("Connection pooling is null.");
        }
        catch (SQLException ex) {
            throw new SQLException("Error when creating a connection.");
        }
    }

    public static JobPool getInstance(String serverName, String dbName, String userName, String password)
                throws SQLException, NullPointerException {
        try {
            String url = DriverUtilities.makeURL(serverName,
                            dbName, DriverUtilities.MYSQL);
                // Create a connection pool has a ten max.
	    ConnectionPool conPool = new JobPool(DriverUtilities.getDriver(DriverUtilities.MYSQL),
                                  url, userName, password, 1, 10, true);
            return (JobPool) conPool;
        }
        catch (NullPointerException ex) {
            throw new NullPointerException("Connection pooling is null.");
        }
        catch (SQLException ex) {
            throw new SQLException("Error when creating a connection.");
        }
    }
}