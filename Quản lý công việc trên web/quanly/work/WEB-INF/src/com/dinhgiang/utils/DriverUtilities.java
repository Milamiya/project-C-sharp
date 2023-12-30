/**
 * @(#)DriverUtilities.java    v.1.0   2003/06/08
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

/**
 * Some simple utilities for building Oracle and Sybase
 * JDBC connections. This is <I>not</I> general-purpose
 * code -- it is specific to my local setup.
 * <p>
 * @author Dinh Le Giang
 * @version 1.0 8 July 2003
 * </p>
 */

public class DriverUtilities {
    public static final int ORACLE = 1;
    public static final int SYBASE = 2;
    public static final int MYSQL  = 3;
    public static final int UNKNOWN = -1;

    /**
     * Build a URL in the format needed by the
     * Oracle, Sybase, and mySQL drivers I am using.
     */
    public static String makeURL(String host, String dbName,
                                   int vendor) {
        if (vendor == ORACLE) {
            return("jdbc:oracle:thin:@" + host + ":1521:" + dbName);
        }
        else if (vendor == SYBASE) {
            return("jdbc:sybase:Tds:" + host  + ":1521"
                   + "?SERVICENAME=" + dbName);
        }
        else if (vendor == MYSQL) {
            return("jdbc:mysql://" + host + "/" + dbName);
        }
        else { // unknown
            return(null);
        }
    }

    /** Get the fully qualified name of a driver. */
    public static String getDriver(int vendor) {
        if (vendor == ORACLE) {
            return("oracle.jdbc.driver.OracleDriver");
        }
        else if (vendor == SYBASE) {
            return("com.sybase.jdbc.SybDriver");
        }
        else if (vendor == MYSQL) {
            return("org.gjt.mm.mysql.Driver");
        }
        else {
            return(null);
        }
    }

    /** Map name to int value. */
    public static int getVendor(String vendorName) {
        if (vendorName.equalsIgnoreCase("oracle")) {
            return(ORACLE);
        }
        else if (vendorName.equalsIgnoreCase("sybase")) {
            return(SYBASE);
        }
        else if (vendorName.equalsIgnoreCase("mysql")) {
            return(MYSQL);
        }
        else {
            return(UNKNOWN);
        }
    }
}
