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
                <th><font face="VNI-Times" color="#003366">Ma� BC</font></th>
                <th><font face="VNI-Times" color="#003366">Nga�y</font></th>
                <th><font face="VNI-Times" color="#003366">Ke�m File</font></th>
                <th><font face="VNI-Times" color="#003366">Tie�n �o�</font></th>
                <th><font face="VNI-Times" color="#003366">Ghi Chu�</font></th>
            </tr>
            <xsl:for-each select="//baocaongay">
                <tr>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./@stt" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./mabcn" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./ngay" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tenfile" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tiendo" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./ghichu" /></font></td>
                </tr>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>