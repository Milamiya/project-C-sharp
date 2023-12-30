/**
 * @(#)UploadedFile.java    v.1.0   2003/07/26
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

import java.io.File;
import java.io.IOException;

/**
 * @author Dinh Le Giang
 * @version 1.0 26 July 2003
 *
 * The Bean to hold information about an uploaded file
 * The Bean used in FileUploaderBean
 * @see com.dinhgiang.beans.FileUploaderBean
 */

public class UploadedFileBean {
    /** This constant set defualt file size */
    private static final int DEFUALT_FILE_SIZE = 0;

    /* Member data (class variables) */

    /** Folder for uploaded files */
    private String folder;

    /** File name sends for server */
    private String filename;

    /** File name saved in server */
    private String savedFile;

    /** Store file type such as image/gif, plain/text, .. */
    private String type;

    /* Contructors for the Bean */
    public UploadedFileBean() {
        this(".", "unknown", "unknown", "");
    }

    /** This contructor initiates four member fields */
    public UploadedFileBean(String f, String fn, String sf, String t) {
        folder = f;
        filename = fn;
        savedFile = sf;
        type = t;
    }

    /** This getter method get content type */
    public String getContentType() {
        return type;
    }

    /** This getter method get file name */
    public String getFileName() {
        return filename;
    }

    /** This getter method get file name */
    public String getSavedFileName() {
        return savedFile;
    }

    /** This getter method get a file object */
    public File getFile() throws IOException {
        if (folder == null || savedFile == null) {
            return null;
        }
        else {
            return new File(folder + File.separator + savedFile);
        }
    }
}