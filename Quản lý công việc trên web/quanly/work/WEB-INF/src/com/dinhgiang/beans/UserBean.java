/**
 * @(#)UserBean.java    v.1.0   2003/07/13
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

/**
 * This bean uses to store username and ip
 * address of client.
 *
 * @author Dinh Le Giang
 * @version 1.0 13 July 2003
 */
public class UserBean implements Comparable {

    private String userId;
    private String password;
    private String staffId;
    private String groupId;
    private String ipAddr;

    public UserBean() {}

    public UserBean(String userId, String password, String groupId, String staffId) {
        this.userId = userId;
        this.password = password;
        this.groupId = groupId;
        this.staffId = staffId;
    }

    public String getPassword() {
        return password;
    }

    public String getUserId() {
        return userId;
    }

    public String getStaffId() {
        return staffId;
    }

    public String getGroupId() {
        return groupId;
    }

    public String getIpAddr() {
        return ipAddr;
    }

    public void setIpAddr(String ipAddr) {
        this.ipAddr = ipAddr;
    }

    public String toString() {
        return userId;
    }

    public int hashCode() {
        /* Improve hashcode calculation using member variables of this class */
        return 13*userId.hashCode() + 7*ipAddr.hashCode();
    }

    public boolean equals(Object user) {
        /* Return true if the result of the compareTo() method is zero */
        return compareTo(user) == 0;
    }

    public int compareTo(Object user) {
        /*- Compare the user IDs of the two user objects -
            result is zero if they're identical
        */
        int result = userId.compareTo(((UserBean)user).getUserId());

        /*- If result is zero from previous method, return the comparison of IP addresses.
            Otherwise, return the result.
         */
        return result == 0 ? ipAddr.compareTo(((UserBean)user).getIpAddr()) : result ;
    }
}