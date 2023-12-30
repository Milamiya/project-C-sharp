<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- xmlns="http://www.w3.org/TR/xhtml1/strict" -->
    <!--
       @description: The stylesheet does transform a XML
        document to a HTML table for showing Suggestion.
    -->
    <xsl:template match="/"> <!-- Root document: congviec -->
        <table border="1" width="100%">
            <tr bgcolor="#DDECEE">
                <th><font face="VNI-Times" color="#003366">STT</font></th>
                <th><font face="VNI-Times" color="#003366">Maõ GY</font></th>
                <th><font face="VNI-Times" color="#003366">Noäi Dung</font></th>
                <th><font face="VNI-Times" color="#003366">Ngaøy</font></th>
                <th><font face="VNI-Times" color="#003366">Keøm File</font></th>
            </tr>
            <xsl:for-each select="//gopy">
                <tr>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./@stt" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./magy" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./noidung" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./ngay" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./mafile" /></font></td>
                </tr>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>