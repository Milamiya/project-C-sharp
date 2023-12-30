/**
 * @(#)ApplyTag.java    v.1.0   2003/07/12
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

package com.dinhgiang.taglibs;

/* Import Java classes for use */
import java.io.InputStream;
import java.io.Reader;
import java.io.StringReader;

import java.lang.reflect.Method;

import javax.servlet.ServletContext;
import javax.servlet.jsp.JspException;
import javax.servlet.jsp.tagext.BodyTagSupport;

import org.apache.xalan.xslt.XSLTInputSource;
import org.apache.xalan.xslt.XSLTProcessor;
import org.apache.xalan.xslt.XSLTProcessorFactory;
import org.apache.xalan.xslt.XSLTResultTarget;

import org.w3c.dom.Node;
import org.xml.sax.InputSource;
import org.xml.sax.SAXException;

/**
 * Apply an XSL stylesheet to an XML data source, rendering the output
 * to the writer of our JSP page.  This tag uses the Xalan XSLT processor,
 *
 * @author Dinh Le Giang
 * @version 1.0 12 July 2003
 */
public class ApplyTag extends BodyTagSupport {
    /**
     * The body content of this tag, if we are using it as the data source.
     */
    private String body = null;

    /**
     * The name of the XML data bean.
     */
    private String nameXml = null;

    /**
     * The name of the XSL stylesheet bean.
     */
    private String nameXsl = null;

    /**
     * The property of the XML data bean.
     */
    private String propertyXml = null;

    /**
     * The property of the XSL stylesheet bean.
     */
    private String propertyXsl = null;

    /**
     * The XML data resource.
     */
    private String xml = null;

    /**
     * The XSL stylesheet resource.
     */
    private String xsl = null;

    public String getNameXml() {
	return (this.nameXml);
    }

    public void setNameXml(String nameXml) {
	this.nameXml = nameXml;
    }

    public String getNameXsl() {
	return (this.nameXsl);
    }

    public void setNameXsl(String nameXsl) {
	this.nameXsl = nameXsl;
    }

    public String getPropertyXml() {
	return (this.propertyXml);
    }

    public void setPropertyXml(String propertyXml) {
	this.propertyXml = propertyXml;
    }

    public String getPropertyXsl() {
	return (this.propertyXsl);
    }

    public void setPropertyXsl(String propertyXsl) {
	this.propertyXsl = propertyXsl;
    }

    public String getXml() {
	return (this.xml);
    }

    public void setXml(String xml) {
	this.xml = xml;
    }

    public String getXsl() {
	return (this.xsl);
    }

    public void setXsl(String xsl) {
	this.xsl = xsl;
    }

    /**
     * Validate the attributes that were specified for consistency.
     * Evaluate the body content of this tag if we will be using it as the
     * XML data source; otherwise skip it.
     *
     * @exception JspException if a JSP error occurs
     */
    public int doStartTag() throws JspException {

	/* Validate the data source attributes */
	if (nameXml != null) {
	    if (xml != null)
		throw new JspException
		    ("Cannot specify both 'nameXml' and 'xml'");
	} else if (propertyXml != null) {
	    throw new JspException
		("Cannot specify 'propertyXml' without 'nameXml'");
	}

	/* Validate the stylesheet source attributes */
	if (nameXsl != null) {
	    if (xsl != null)
		throw new JspException
		    ("Cannot specify both 'nameXsl' and 'xsl'");
	} else if (propertyXsl != null) {
	    throw new JspException
		("Cannot specify 'propertyXsl' without 'nameXsl'");
	}
	if ((nameXsl == null) && (xsl == null)) {
	    throw new JspException
		("Must specify either 'nameXsl' or 'xsl'");
	}

	/* Evaluate the tag body only if we need it */
	if ((nameXml == null) && (xml == null))
	    return (EVAL_BODY_TAG);
	else
	    return (SKIP_BODY);
    }

    /**
     * Save the body content that has been processed, but do not iterate.
     *
     * @exception JspException if a JSP error has occurred
     */
    public int doAfterBody() throws JspException {

	if (bodyContent == null)
	    body = "";
	else
	    body = bodyContent.getString().trim();
	return (SKIP_BODY);

    }

    /**
     * Finish up by performing the transformation and rendering the output.
     *
     * @exception JspException if a JSP exception occurs
     */
    public int doEndTag() throws JspException {

	/* Prepare an input source for the data */
	XSLTInputSource data = null;
	if (body != null)
	    data = new XSLTInputSource(new StringReader(body));
	else
	    data = getInputSource(nameXml, propertyXml, xml);

	/* Prepare an input source for the stylesheet */
	XSLTInputSource style =
	    getInputSource(nameXsl, propertyXsl, xsl);

	/* Prepare an output source for the results */
	XSLTResultTarget result =
	    new XSLTResultTarget(pageContext.getOut());

	/*- Create an XSLT processor and use it to
            perform the transformation
         */
	XSLTProcessor processor = null;
	try {
	    processor = XSLTProcessorFactory.getProcessor();
	    processor.process(data, style, result);
	} catch (SAXException e) {
	    throw new JspException(e.toString());
	}
	return (EVAL_PAGE);

    }

    /**
     * Release any allocated resources.
     */
    public void release() {

	this.body = null;

    }

    /**
     * Construct and return an XSLTInputSource based on the specified
     * parameters.
     *
     * @param name Name of a bean containing the input source (or has a
     *  property that returns the input source)
     * @param property Name of a property of the specified bean that
     *  returns the input source
     * @param resource Context-relative path to an application resource
     *  that provides the input source
     *
     * @exception JspException if a JSP error occurs
     */
    private XSLTInputSource getInputSource(String name, String property,
					   String resource)
	throws JspException {
	/*- If the resource is specified, use that
            for the input source
         */
	if (resource != null) {
	    ServletContext context = pageContext.getServletContext();
	    if (context == null)
		throw new JspException("Cannot find servlet context");
	    InputStream stream =
		context.getResourceAsStream(resource);
	    if (stream == null)
		throw new JspException("Missing resource '" + resource + "'");
	    return new XSLTInputSource(stream);
	}

	/* Locate the source object */
	Object source = null;
	Object bean = pageContext.findAttribute(name);
	if (bean == null)
	    throw new JspException("Missing bean '" + name + "'");
	if (property == null)
	    source = bean;
	else {
	    try {
		char first = Character.toUpperCase(property.charAt(0));
		String methodName = "get" + first + property.substring(1);
		Class paramTypes[] = new Class[0];
		Method method =
		    bean.getClass().getMethod(methodName, paramTypes);
		source = method.invoke(bean, new Object[0]);
	    } catch (Exception e) {
		throw new JspException(e.toString());
	    }
	}
	/*- Create an XSLTInputSource for the
            specified source object
         */
	if (source instanceof XSLTInputSource)
	    return ((XSLTInputSource) source);
	else if (source instanceof String)
	    return (new XSLTInputSource(new StringReader((String) source)));
	else if (source instanceof InputSource)
	    return (new XSLTInputSource((InputSource) source));
	else if (source instanceof InputStream)
	    return (new XSLTInputSource((InputStream) source));
	else if (source instanceof Node)
	    return (new XSLTInputSource((Node) source));
	else if (source instanceof Reader)
	    return (new XSLTInputSource((Reader) source));
	else
	    throw new JspException("Invalid input source type '" +
				   source.getClass().getName() + "'");
    }
}
