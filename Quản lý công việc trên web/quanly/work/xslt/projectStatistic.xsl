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
                <th><font face="VNI-Times" color="#003366">Teân CV</font></th>
                <th><font face="VNI-Times" color="#003366">Ngöôøi Thöïc Hieän</font></th>
                <th><font face="VNI-Times" color="#003366">Hoaøn Thaønh?</font></th>
                <th><font face="VNI-Times" color="#003366">Ngaøy BÑ</font></th>
                <th><font face="VNI-Times" color="#003366">Ngaøy KT</font></th>
            </tr>
            <xsl:for-each select="works">
                <tr>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./@stt" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tencv" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tennv" /></font></td>
                    <xsl:choose>
                        <xsl:when test="./daxong=0">
                            <td align="center"><font face="VNI-Times">Chöa</font></td>
                        </xsl:when>
                        <xsl:otherwise>
                            <td align="center"><font face="VNI-Times">Roài</font></td>
                        </xsl:otherwise>
                    </xsl:choose>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./ngaybd" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./ngaykt" /></font></td>
                </tr>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>