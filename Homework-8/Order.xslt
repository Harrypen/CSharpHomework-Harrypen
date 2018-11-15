<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

  <xsl:template match="/ArrayOfOrder">
    <html>
      <body>
        <h2>Order</h2>
        <table border="1">
          <xsl:for-each select="Order">
            <tr bgcolor="#33A4FF">
              <th>OrderId</th>
              <th>Client</th>
            </tr>
            <tr>
              <td>
                <xsl:value-of select="OrderId" />
              </td>
              <td>
                <xsl:value-of select="Client" />
              </td>
            </tr>
            <xsl:for-each select="MyOrder/OrderDetails">
              <tr bgcolor="#9acd32">
                <th>DetailsNumber</th>
                <th>Good</th>
                <th>TotalPrice</th>
                <th>CommodityNumber</th>
              </tr>
              <tr>
                <td>
                  <xsl:value-of select="DetailsNumber" />
                </td>
                <td>
                  <xsl:value-of select="goodName" />
                </td>
                <td>
                  <xsl:value-of select="TotalPrice" />
                </td>
                <td>
                  <xsl:value-of select="CommodityNumber" />
                </td>
              </tr>
            </xsl:for-each>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>

</xsl:stylesheet>