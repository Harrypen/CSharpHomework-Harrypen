<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="ArrayOfOrder">
    <html>
      <head>
        <title>Order</title>
      </head>
      <body>  
            <ul>
                 <xsl:for-each select="Order">
                   <h1>订单</h1>
               <li>
              <b>订单号：</b><xsl:value-of select="OrderId"/>
            </li>     
               <li>
              <b>客户名：</b><xsl:value-of select="Client"/>
            </li> 
                 <li>
              <b>总金额：</b><xsl:value-of select="sum"/>
                   <ul>
                   <xsl:for-each select="MyOrder/OrderDetails">
                     <li>
                      <b>商品名：</b><xsl:value-of select="goodName"/><b>  数量：</b> <xsl:value-of select="CommodityNumber"/>
                     
                   </li>                  
                   </xsl:for-each>
                   </ul>
                   <br/><br/>
            </li> 
              </xsl:for-each>                       
            </ul>               
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>