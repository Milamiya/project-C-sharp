/**
 * @(#)FileUploaderStreamHandler.java    v.1.0    2003/07/26
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

import javax.servlet.ServletInputStream;
import java.io.IOException;

/**
 * The Class used in FileUploader
 * @see com.dinhgiang.utils.FileUploader
 * @author Dinh Le Giang
 * @version 1.0 26 July 2003
 */
public class FileUploaderStreamHandler {
    /** This constant set defualt buffer size is 8 KB */
    private static final int DEFUALT_BUFFER_SIZE = 8 * 1024;
    private static final int DEFUALT_ZERO        = 0;
    private static final int DEFUALT_NEGATIVE    = -1;
    private static final int DEFUALT_POSITIVE    = 1;

    /* Member data (class variables) */

    /** used to store binary data from request,
     * including an efficient readLine method
     * for reading data one line at a time.
     */
    private ServletInputStream servletInputStream;

    /** This field holds boundary key */
    private String boundary;

    /** Buffer holds data to prepare for saving into system file */
    private byte[] buffer;// = new byte[DEFUALT_BUFFER_SIZE];

    private int totalExpected;
    private int totalRead;

    public FileUploaderStreamHandler() {

    }
    /** Constructor has three argurments used to initiate member data */
    public FileUploaderStreamHandler(ServletInputStream in,
                                     String bound,
                                     int totalExp) {
        buffer = new byte[DEFUALT_BUFFER_SIZE];
        servletInputStream = in;
        boundary = bound;
        totalExpected = totalExp;
        totalRead = DEFUALT_ZERO;
    }

    /** Read a line from class variable - buffer - and
     * add it to StringBuffer
     */
    public String readLine() throws IOException {
        StringBuffer sBuf = new StringBuffer();
        int result;
        String line;

        do {
            result = readLine(buffer, 0, buffer.length); // this.readLine() does +=
            if (result != DEFUALT_NEGATIVE) {
                sBuf.append(new String(buffer, DEFUALT_ZERO,
                                        result, "ISO-8859-1"));
            }
        } while (result == buffer.length); // loop only if the buffer was filled

        if (sBuf.length() == DEFUALT_ZERO) {
            return null; // nothing read, must be at the end of stream
        }

        sBuf.setLength(sBuf.length() - 2); // cut off the trailing \r\n
        return sBuf.toString();
    }

    public int readLine(byte b[], int off, int len) throws IOException {
        if (totalRead >= totalExpected) {
            return DEFUALT_NEGATIVE;
        }
        else {
            int result = servletInputStream.readLine(b, off, len);
            if (result > DEFUALT_ZERO) {
                totalRead += result;
            }
            return result;
        }
    }
}