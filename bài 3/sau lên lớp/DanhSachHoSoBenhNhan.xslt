<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
      <html>
        <head>
          <title>Danh sách bệnh nhân</title>
        </head>
        <xsl:for-each select="DSBN/Khoa">
        <body>
          <table border="0">
            <tr>
              <td>BỆNH VIỆN ĐA KHOA</td>
              <th>DANH SÁCH BỆNH NHÂN</th>
            </tr>
            <tr>
              <td>
                Khoa: <xsl:value-of select="@tenkhoa"/>
              </td>
          </tr>
          </table>
          <table border="2" cellpading="3">
            <tr>
              <td>STT</td>
              <td>Họ tên</td>
              <td>Ngày nhập viện</td>
              <td>Số ngày điều trị</td>
              <td>Số tiền phải trả</td>
            </tr>
            <xsl:for-each select="HSBN">
              <tr>
                <td>
                  <xsl:value-of select="position()"></xsl:value-of>
                </td>
                <td>
                  <xsl:value-of select="hoten"/>
                </td>
                <td>
                  <xsl:value-of select="ngaynhapvien"/>
                </td>
                <td>
                  <xsl:value-of select="songaynamvien"/>
                </td>
                <td>
                  <xsl:value-of select="songaynamvien * 15000"/>
                </td>
              </tr>
            </xsl:for-each>
          </table>
        </body>
        </xsl:for-each>
      </html>
    </xsl:template>
</xsl:stylesheet>
