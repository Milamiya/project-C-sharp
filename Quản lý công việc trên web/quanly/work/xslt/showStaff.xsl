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
                <th><font face="VNI-Times" color="#003366">Maõ NV</font></th>
                <th><font face="VNI-Times" color="#003366">Teân NV</font></th>
                <th><font face="VNI-Times" color="#003366">Ngaøy Sinh</font></th>
                <th><font face="VNI-Times" color="#003366">Ñòa Chæ</font></th>
                <th><font face="VNI-Times" color="#003366">Ñieän Thoaïi</font></th>
                <th><font face="VNI-Times" color="#003366">Thuoäc Nhoùm</font></th>
            </tr>
            <xsl:for-each select="//nhanvien">
                <tr>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./@stt" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./manv" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tennv" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./ngaysinh" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./diachi" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./phone" /></font></td>
                    <td><font face="VNI-Times"><xsl:apply-templates select="./tengroup" /></font></td>
                </tr>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>