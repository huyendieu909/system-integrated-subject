<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
      <html>
        <head>
          <title>Bai1</title>
        </head>
        <body>
          <table border="1" cellpadding="10px">
            <tr>
              <th width="150px" align="left">MaLop</th>
              <th width="500px" align="left">TenLop</th>
            </tr>
            <xsl:for-each select="lop/lophoc">
              <tr>
                <td>
                  <xsl:value-of select="MaLop"/>
                </td>
                <td>
                  <xsl:value-of select="TenLop"/>
                </td>
              </tr>
            </xsl:for-each>
          </table>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>
