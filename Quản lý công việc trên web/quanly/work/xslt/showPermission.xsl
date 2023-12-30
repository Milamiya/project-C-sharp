<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- xmlns="http://www.w3.org/TR/xhtml1/strict" -->
    <!--
        @description: The stylesheet does transform a XML
        document to a HTML table for showing permissions.
    -->
    <xsl:template match="/">
        <table border="1" width="100%">
            <tr bgcolor="#DDECEE">
                <th><font face="VNI-Times" color="#003366">STT</font></th>
                <th><font face="VNI-Times" color="#003366">Ma� Quye�n</font></th>
                <th><font face="VNI-Times" color="#003366">Te�n Quye�n</font></th>
                <th><font face="VNI-Times" color="#003366">Ghi Chu�</font></th>
            </tr>
            <xsl:for-each select="//permissions">
                <tr>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./@stt" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./maper" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tenper" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./ghichu" /></font></td>
                </tr>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>