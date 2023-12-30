<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- xmlns="http://www.w3.org/TR/xhtml1/strict" -->
    <!--
        @description: The stylesheet does transform a XML
        document to a HTML table for showing Work Value.
    -->
    <xsl:template match="congviec"> <!-- Root document: congviec -->
        <table border="1" width="100%" align="center">
            <tr bgcolor="#DDECEE">
                <th><font face="VNI-Times" color="#003366">STT</font></th>
                <th><font face="VNI-Times" color="#003366">Te�n CV</font></th>
                <th><font face="VNI-Times" color="#003366">Ng���i Th��c Hie�n</font></th>
                <th><font face="VNI-Times" color="#003366">Hoa�n Tha�nh?</font></th>
                <th><font face="VNI-Times" color="#003366">Nga�y B�</font></th>
                <th><font face="VNI-Times" color="#003366">Nga�y KT</font></th>
            </tr>
            <xsl:for-each select="works">
                <tr>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./@stt" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tencv" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tennv" /></font></td>
                    <xsl:choose>
                        <xsl:when test="./daxong=0">
                            <td align="center"><font face="VNI-Times">Ch�a</font></td>
                        </xsl:when>
                        <xsl:otherwise>
                            <td align="center"><font face="VNI-Times">Ro�i</font></td>
                        </xsl:otherwise>
                    </xsl:choose>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./ngaybd" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./ngaykt" /></font></td>
                </tr>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>