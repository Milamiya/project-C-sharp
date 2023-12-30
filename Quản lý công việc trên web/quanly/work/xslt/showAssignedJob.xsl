<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- xmlns="http://www.w3.org/TR/xhtml1/strict" -->
    <!--
        @description: The stylesheet does transform a XML
        document to a HTML table for showing Report.
    -->
    <xsl:template match="/"> <!-- Root document: congviec -->
        <table border="1" width="100%">
            <tr bgcolor="#DDECEE">
                <th><font face="VNI-Times" color="#003366">STT</font></th>
                <th><font face="VNI-Times" color="#003366">Te�n CV</font></th>
                <th><font face="VNI-Times" color="#003366">No�i Dung</font></th>
                <th><font face="VNI-Times" color="#003366">Nga�y BD</font></th>
                <th><font face="VNI-Times" color="#003366">Nga�y KT</font></th>
                <th><font face="VNI-Times" color="#003366">Thuo�c �e� A�n</font></th>
            </tr>
            <xsl:for-each select="//works">
                <tr>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./@stt" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tencv" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./noidung" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./ngaybd" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./ngaykt" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tenda" /></font></td>
                </tr>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>