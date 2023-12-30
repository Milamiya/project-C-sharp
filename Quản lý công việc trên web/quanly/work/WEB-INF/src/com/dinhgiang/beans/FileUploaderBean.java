/**
 * @(#)FileUploader.java    v.1.0   2003/07/26
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

import javax.servlet.ServletRequest;
import java.util.Hashtable;
import java.util.Enumeration;
import java.io.File;
import java.io.FileOutputStream;
import java.io.BufferedOutputStream;
import java.io.IOException;

/* Import my classes */
import com.dinhgiang.utils.FileUploaderStreamHandler;

/**
 * @author Dinh Le Giang
 * @version 1.0 26 July 2003
 *
 * The Bean used in any Servlet to upload files from
 * request and save it persistent object (File on Server)
 * The Bean also uses UploadedFileBean and FileUploaderStreamHandler
 * utility class
 * @see com.dinhgiang.beans.UploadedFileBean
 * @see com.dinhgiang.utils.FileUploaderStreamHandler
 */
public class FileUploaderBean {
    /** This constant set defualt buffer size is 1 MB */
    private static final int DEFUALT_MAX_POST_SIZE = 1024 * 1024;
    private static final int DEFUALT_BUFFER_SIZE   = 1024 * 8; // 8 KB
    private static final int DEFUALT_ZERO          = 0;
    private static final int DEFUALT_NEGATIVE      = -1;
    private static final int DEFUALT_POSITIVE      = 1;

    /* Member data (class variables) */

    /** Store a request from client */
    private ServletRequest request;

    private File folder;
    private int maxSize;
    private int orderNum = 0;
    private String savedFile; // is file name stored trully in hard disk

    /** parameters variable to hold (name - value) */
    private Hashtable parameters;

    /** files variable to hold (name - UploadedFileBean) */
    private Hashtable files;

    /* Constructors */

    public FileUploaderBean() {

    }

    public FileUploaderBean(ServletRequest req,
                            String saveFolder) throws IOException {
        this(req, saveFolder, DEFUALT_MAX_POST_SIZE);
    }

    public FileUploaderBean(ServletRequest req,
                            String saveFolder,
                            int maxPostSize) throws IOException {
        /* initiate hashtable */
        parameters = new Hashtable();
        files = new Hashtable();

        /* sanity check values */
        if (req == null) {
            throw new IllegalArgumentException("req cannot be null");
        }
        if (saveFolder == null) {
            throw new IllegalArgumentException("saveFolder cannot be null");
        }
        if (maxPostSize <= DEFUALT_NEGATIVE) {
            throw new IllegalArgumentException("maxPostSize must be positive");
        }

        /* Save the request, folder, and max size */
        request = req;
        folder = new File(saveFolder);
        maxSize = maxPostSize;

        /* Check saveFolder is truly a folder */
        if (!folder.isDirectory()) {
            throw new IllegalArgumentException("Not a folder:" + saveFolder);
        }
        /* Ckeck saveFolder is writable */
        if (!folder.canWrite()) {
            throw new IllegalArgumentException("Not writable:" + saveFolder);
        }

        /*- Now parse the request saving data to "parameters"
            and "files" write the file contents to the saveFolder
         */
        //readRequest();
    }

    /* getter methods */
    public File getFolder() {
        return folder;
    }

    /**
     * This method returns the names of all the parameters
     * as an Enumeration of String objects of an empty Enumeration
     * if there are no parameters.
     */
    public Enumeration getParameterNames() {
        return parameters.keys();
    }

    /** To get the value a named parameter */
    public String getParameter(String name) {
        try {
            String param = (String) parameters.get(name);
            if (param.equals("")) {
                return null;
            }
            return param;
        }
        catch (Exception ex) {
            return null;
        }
    }

    /** To get a list of all the uploaded files */
    public Enumeration getFileNames() {
        return files.keys();
    }

    /**
     * Once we have the name of a file, we can get
     * its file system name using the following method
     */
    public String getTrulyFileName(String name) {
        try {
            UploadedFileBean file = (UploadedFileBean) files.get(name);
            return file.getFileName(); // may be null
        }
        catch (Exception ex) {
            return null;
        }
    }

    public String getSavedFileName(String name) {
        try {
            UploadedFileBean file = (UploadedFileBean) files.get(name);
            return file.getSavedFileName(); // may be null
        }
        catch (Exception ex) {
            return null;
        }
    }

    /**
     * Return the content type of the specified file
     * such as plain/text
     */
    public String getContentType(String name) {
        try {
            UploadedFileBean file = (UploadedFileBean) files.get(name);
            return file.getContentType(); // mat be null
        }
        catch (Exception ex) {
            return null;
        }
    }

    /**
     * this method returns a File object for the
     * specified file saved on the server's file system
     * of null if the file was not included in the upload.
     */
    public File getFile(String name) {
        try {
            UploadedFileBean file = (UploadedFileBean) files.get(name);
            return file.getFile(); // may be null
        }
        catch (Exception ex) {
            return null;
        }
    }

    /**
     * read a request from client
     */
    public void readRequest() throws IOException {
        /* Check the content type to make sure it's "multipart/form-data" */
        String type = request.getContentType();
        if (type == null ||
            !type.toLowerCase().startsWith("multipart/form-data")) {
            throw new IOException("Posted content type isn't multipart/form-data");
        }

        /* Check the content length to prevent denial of service attacks */
        int length = request.getContentLength();
        if (length > maxSize) {
            throw new IOException("Posted content length of " + length
                                    + " exceeds limit of " + maxSize);
        }

        /* Check boundary string; it's included in the content type.
           Should look something like
           "Content-type: multipart/form-data, boundary=AaB03x"
         */
        String boundary = extractBoundary(type);
        if (boundary == null) {
            throw new IOException("Seperation boundary is specified");
        }

        /* Construct the special input stream we'll read from */
        FileUploaderStreamHandler stream = new FileUploaderStreamHandler(request.getInputStream(),
                                                        boundary,
                                                        length);

        /* Read the first line, should be the first boundary */
        String line = stream.readLine();
        if (line == null) {
            throw new IOException("Corrupt form data: premature ending");
        }

        /* Verify the the line is the boundary */
        if (!line.startsWith(boundary)) {
            throw new IOException("Corrupt form data: no leading boundary");
        }

        /* Now that we're just beyond the first boundary,
           loop over each part
         */
        boolean done = false;
        while (!done) { // done == false
            done = readNextPart(stream, boundary, length);
        }
    }

    /**
     * Read the first line, should look like this:
     * content-disposition: form-data; name="field1"; filename="file1.txt"
     */
    protected boolean readNextPart(FileUploaderStreamHandler stream,
                                   String boundary,
                                   int filesize) throws IOException {
        String line = stream.readLine();
        /*String line1 = stream.readLine();
        String line2 = stream.readLine();
        String line3 = stream.readLine();*/
        if (line == null || line.equals("")) {
            return true; //No parts left, we're done
        }

        /* Parse the content-disposition line */
        String[] dispInfo = extractDispositionInfo(line);
        String disposition = dispInfo[0];
        String name = dispInfo[1];
        String filename = dispInfo[2]; // Only display for user

        /*- Now onto the next line. This will either be empty
            or contain a Content-type and then a empty line.
         */
        line = stream.readLine();
        if (line == null) { //  || line.equals("")
            return true; // No parts left, we're done
        }

        /* Get the content type, or null if none specified */
        String contentType = extractContentType(line);
        if (contentType != null) {
            /*Eat the empty line */
            line = stream.readLine();
            if (line == null || line.length() > DEFUALT_ZERO) { // line should be empty
                throw new IOException("Malformed line after disposition: " + line);
            }
        }
        else { // Assume a defualt content type
            contentType = "application/octet-stream";
        }

        /* Now, finally, we read the content (end after reading the boundary) */
        if (filename == null) {
            /* This is a parameter */
            String value = readParameter(stream, boundary);
            parameters.put(name, value);
            if (name.startsWith("mabc") || name.startsWith("magy")) { // get 'mabc' as file name
                savedFile = value;
            }
        }
        else {
            /* This is a file */
            if (filename.equals("unknown")) {
                files.put(name, new UploadedFileBean(null, null, null, null));
            }
            else {

	        /*- Determine file name for saving on server
      	            if there are many files, increment with
            	    order number.
	         */
      	        String no = "";
                if (orderNum != 0) {
	            no += "_" + orderNum;
      	            savedFile = savedFile.substring(0, savedFile.indexOf("."));
                }
	        savedFile = savedFile + no + filename.substring(filename.indexOf("."));
      	        orderNum ++;

      	        readAndSaveFile(stream, boundary, savedFile); // save file in web server.

                files.put(name,
                          new UploadedFileBean(folder.toString(),
                                               filename,
                                               savedFile,
                                               contentType));
            }
        }
        return false; // there's more to read
    }

    /**
     * Get parameter from a ServletInputStream (client request).
     * when form submitted.
     */
    protected String readParameter(FileUploaderStreamHandler stream,
                                   String boundary) throws IOException {
        StringBuffer sBuf = new StringBuffer();
        String line;

        while ((line = stream.readLine()) != null) {
            if (line.startsWith(boundary)) {
                break;
            }
            sBuf.append(line + "\r\n"); // add the \r\n in case thre are many lines
        }

        if (sBuf.length() == DEFUALT_ZERO) {
            return null; // nothing read
        }

        sBuf.setLength(sBuf.length() - 2); // cut off the lst line's \r\n
        return sBuf.toString(); // no URL decoding needed
    }

    protected void readAndSaveFile(FileUploaderStreamHandler stream,
                                   String boundary,
                                   String filename) throws IOException {
        File file = new File(folder + File.separator + filename);
        FileOutputStream outStream = new FileOutputStream(file);
        BufferedOutputStream bufferOutStream =
                        new BufferedOutputStream(outStream,
                                                 DEFUALT_BUFFER_SIZE);
        byte[] bbuf = new byte[DEFUALT_BUFFER_SIZE];
        int result;
        String line;
        /*- ServletInputStream.readLine() has the annoying habit
            adding a \r\n to the end of the last line. Since we
            want a byte-for-byte tranfer, we have to cut those chars.
         */
        boolean rnflag = false;
        while ((result = stream.readLine(bbuf, DEFUALT_ZERO, bbuf.length)) != DEFUALT_NEGATIVE) {
            /* Ckeck for boundary */
            if ((result > 2) && (bbuf[0] == '-') && (bbuf[1] == '-')) { // quick pre-check
                line = new String(bbuf, DEFUALT_ZERO, result, "ISO-8859-1");
                if (line.startsWith(boundary)) {
                    break;
                }
            }

            /* Are we supposed to write \r\n for the last iteration? */
            if (rnflag) {
                bufferOutStream.write('\r');
                bufferOutStream.write('\n');
                rnflag = false;
            }

            /**/
            if ((result >= 2) && (bbuf[result - 2] == '\r') &&
                (bbuf[result - 1] == '\n')) {
                bufferOutStream.write(bbuf, DEFUALT_ZERO, result - 2); // skip the last 2 chars
                rnflag = true; // make a note to write them on the next iteration
            }
            else {
                bufferOutStream.write(bbuf, DEFUALT_ZERO, result);
            }
        } // end of while
        bufferOutStream.flush();
        bufferOutStream.close();
        outStream.close();
    }

    /**
     * Extract boundary from request has following form
     * Content-type: multipart/form-data, boundary=AaB03x
     *              empty line
     * --AaB03x (real boundary get started with "--")
     */
    private String extractBoundary(String line) {
        int index = line.indexOf("boundary=");
        if (index == DEFUALT_NEGATIVE) {
            return null;
        }
        String boundary = line.substring(index + 9); // 9 for "boundary="

        // The real boundary is always preceded by an extra "--"
        boundary = "--" + boundary;
        return boundary;
    }

    /**
     * Extract dispostion from client request that look something like
     * content-disposition: form-data; name="pics"; filename="file1.txt"
     * This method returns the line's data as an array: disposition
     * name, filename
     */
    private String[] extractDispositionInfo(String line) throws IOException {
        try {
        String[] retval = new String[3];

        /* Convert the line to a lowercase string without
           the end \r\n keep the original line for error
           messages and for varable names.
        */
        String origline = line;
        line = origline.toLowerCase();

        /* Get the content diposition, should be "form-data" */
        int start = line.indexOf("content-disposition: "); // = 21 characters
        int end = line.indexOf(";");
        if (start == DEFUALT_NEGATIVE || end == DEFUALT_NEGATIVE) {
            throw new IOException("Content disposition corrupt: " + origline);
        }
        String disposition = line.substring(start + 21, end);
        if (!disposition.equals("form-data")) {
            throw new IOException("Invalid content disposition: " + disposition);
        }

        /* Get the field name (pics) */
        start = line.indexOf("name=\"", end); // = 7 characters ex: name="pics";
        end = line.indexOf("\"", start + 7); // kip name=\"
        if (start == DEFUALT_NEGATIVE || end == DEFUALT_NEGATIVE) {
            throw new IOException("Content disposition corrupt: " + origline);
        }
        String name = origline.substring(start + 6, end);

        /* Get the file name, if given */
        String filename = null;
        start = line.indexOf("filename=\"", end + 2); // 2 is kip "; " space
        end  = line.indexOf("\"", start + 10); // 10 = filename="
        /* Note the != */
        if (start != DEFUALT_NEGATIVE && end != DEFUALT_NEGATIVE) {
            filename = origline.substring(start + 10, end);
            /*- The file name may contain a full path.
                Cut to just the filename.
             */
            int slash = Math.max(filename.lastIndexOf('/'),
                                 filename.lastIndexOf('\\'));

            if (slash > DEFUALT_NEGATIVE) {
                filename = filename.substring(slash + 1); // past last slash
            }
            if (filename.equals("")) {
                filename = "unknown"; // sanity check
            }
        }

        /* Return s String array: disposition, name, filename */
        retval[0] = disposition;
        retval[1] = name;
        retval[2] = filename;
        return retval;
        }
        catch (IndexOutOfBoundsException ex) {
            throw new IndexOutOfBoundsException("Index Out Of Bound");
        }
    }

    private String extractContentType(String line) throws IOException {
        String contentType = null;

        /* Convert the line to the lowercase string */
        String origline = line;
        line = origline.toLowerCase();

        /* Get the content type, if any */
        if (line.startsWith("content-type")) {
            int start = line.indexOf(""); // " " = 1
            if (start == DEFUALT_NEGATIVE) {
                throw new IOException("Content-type corrupt: " + origline);
            }
            contentType = line.substring(start); // + 1
        }
        else if (line.length() != DEFUALT_ZERO) { // no content type, so should be empty
            throw new IOException("Malformed line after disposition: " + origline);
        }
        return contentType;
    }
}