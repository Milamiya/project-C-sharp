<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- xmlns="http://www.w3.org/TR/xhtml1/strict" -->
    <!--
        @description: The stylesheet does transform a XML
        document to a HTML table for showing permissions.
    -->
    <xsl:template match="/"> <!-- Root document: congviec -->
        <table border="1" width="100%">
            <tr bgcolor="#DDECEE">
                <th><font face="VNI-Times" color="#003366">STT</font></th>
                <th><font face="VNI-Times" color="#003366">Maõ Nhoùm</font></th>
                <th><font face="VNI-Times" color="#003366">Teân Nhoùm</font></th>
                <th><font face="VNI-Times" color="#003366">Tröôûng Nhoùm</font></th>
                <th><font face="VNI-Times" color="#003366">Ngaøy Nhaän Chöùc</font></th>
            </tr>
            <xsl:for-each select="//groups">
                <tr>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./@stt" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./magroup" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tengroup" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./trggroup" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./ngaync" /></font></td>
                </tr>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>