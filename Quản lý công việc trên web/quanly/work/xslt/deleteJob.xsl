<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- xmlns="http://www.w3.org/TR/xhtml1/strict" -->
    <!--
        @description: The stylesheet does display a table
        for deleting a Job.
    -->
    <xsl:template name="doJob">
        <xsl:for-each select="//works">
            <xsl:variable name="jobid" select="macv/text()" />
            <tr>
                <td><font face="VNI-Times"><xsl:value-of select="@stt" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="macv" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="tencv" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="noidung" /></font></td>
                <td><font face="VNI-Times"><xsl:value-of select="mada" /></font></td>
                <!--td><font face="VNI-Times"><xsl:value-of select="daxong" /></font></td-->
                <td><font face="VNI-Times"><input type="checkbox" name="deleteJob" value="{$jobid}" /></font></td>
            </tr>
        </xsl:for-each>
    </xsl:template>
    <xsl:template match="/"> <!-- Root document: congviec -->
        <table border="1" width="100%">
            <tr bgcolor="#DDECEE">
                <th><font face="VNI-Times" color="#003366">STT</font></th>
                <th><font face="VNI-Times" color="#003366">Ma� CV</font></th>
                <th><font face="VNI-Times" color="#003366">Te�n CV</font></th>
                <th><font face="VNI-Times" color="#003366">No�i Dung</font></th>
                <th><font face="VNI-Times" color="#003366">Thuo�c �e� A�n</font></th>
                <!--th><font face="VNI-Times" color="#003366">Hoa�n Tha�nh?</font></th-->
                <th><font face="VNI-Times" color="#003366">&#160;&#160;&#160;</font></th>
            </tr>
            <xsl:call-template name="doJob" />
        </table>
    </xsl:template>
</xsl:stylesheet>