<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="amplodis-forum.aspx.cs" Inherits="Amplodis.AmplodisBlog.amplodis_forum" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="../../../favicon.ico">
    <title>Amplodis Technical Forum</title>
    <link href="../css/web-global.css" rel="stylesheet">
    <link href="../font-awesome/css/font-awesome.css" rel="stylesheet">
    
</head>
<body>
    <div id="page1" class="gd-row page1">
        <div id="navbar" class="gd-container ws-clearfix">
            <!--<a id="touch-menu" class="mobile-menu" href="#"><i class="icon-reorder"></i>Menu</a> -->
            <div class="navbar-brand">
                <a class="navbar-logo" href="http://www.amplodis.com">
                    <img alt="logo" src="../images/amplodis-logo-white.png" />
                </a>
            </div>
            <nav>
                <a id="touch-menu" class="mobile-menu" href="#"><i class="icon-reorder"></i>Menu</a>
                <ul class="menu">
                      <li><a href="../default"><i class="icon-home"></i>Home</a></li>
                <li><a href="../about-us.html"><i class="icon-user"></i>About Us</a></li>
                <li><a href="../amplodis-services.html"><i class="icon-cog"></i>Services</a></li>
              <li><a href="AmplodisBlog/amplodis-forum"><i class="icon-bullhorn"></i>Blog</a></li>
              <li><a  href="#"><i class="icon-envelope-alt"></i>Contact</a></li>
                </ul>
            </nav>
        </div>
        <!--end mainWrap-->
    </div>
    <div id="blog-page" class="gd-row blog-page">
        <div class="gd-container ws-clearfix blog-content" id="dvContainerTag" runat="server">            
            
        </div>
    </div>
    <div id="page8" class="gd-row page8">
        <div class="gd-container ws-clearfix blog-content">
            <form id="form1" runat="server">
                <asp:GridView ID="grdBlog" runat="server" AutoGenerateColumns="false" Visible="false" ShowHeader="false" GridLines="None" OnSelectedIndexChanged="grdBlog_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <article class="blog-artical tag-software-development">
                                    <div class="even">
                                        <header class="clearfix">
                                            <h2 class="blog-title">
                                                <a class="link" href="Amplodis-forum-detail.aspx?ID=<%# DataBinder.Eval(Container.DataItem, "Id") %>"><%# DataBinder.Eval(Container.DataItem, "BlogName") %></a>
                                            </h2>
                                            <div class="authorname">By &nbsp;<a class="brand-link" rel="author" title="Posts by Devendra Tiwari" href="#"><%# DataBinder.Eval(Container.DataItem, "UserFirstName") %><%# DataBinder.Eval(Container.DataItem, "UserLastName") %></a></div>
                                            <div class="date-title details">
                                                <i class="icon-calendar b_alpha"></i><span class="date"><%# DataBinder.Eval(Container.DataItem, "CreatedDate", "{0:d}") %></span>
                                                <span class="tags">
                                                    <a rel="category tag" class="brand-link" href="#"><i class="icon-tag"></i><%# DataBinder.Eval(Container.DataItem, "TagName") %></a></span>
                                            </div>
                                            <div class="summaryofblog">
                                                <!--div class="tcenter image-container">
                                                    <img alt="http://www.dmxzone.com/downloads/images/phonegap.png" src="http://www.dmxzone.com/downloads/images/phonegap.png"
                                                        class="size-full">
                                                    <p class="image-caption-text">need to mention image url for SEO purpose</p>
                                                </div-->
                                                <p><%# DataBinder.Eval(Container.DataItem, "Description") %></p>
                                                <div class="readmore"><a href="Amplodis-forum-detail.aspx?ID=<%# DataBinder.Eval(Container.DataItem, "Id") %>" class="main-rev-btn">Continue Reading <i class="icon-fixed-width icon-chevron-right"></i></a></div>
                                            </div>
                                        </header>
                                    </div>
                                </article>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>                
            </form>
        </div>
    </div>
    <!-- /.footer-Meta -->
    <div class="gd-row">
        <section class="footer-meta">
            <div class="gd-container">
                <div class="gd-grid-12">
                    <p class="copyright-area">CopyRight 2014  <a href="#" class="brand-link">amplodis</a> .  All Rights Reserved. Creative by <a href="http://www.amplodis.com" class="brand-link"><b>amplodis @creative</b></a></p>
                </div>
                <div class="gd-grid-12">
                    <ul class="social-links">
                        <li class="social-title"><b>Follow Us</b></li>
                        <li class="social-facebook"><a href="#" target="_blank"><i class="icon-facebook-sign icon-2x"></i></a>
                        </li>
                        <li class="social-twitter"><a href="#" target="_blank"><i class="icon-twitter-sign icon-2x"></i></a>
                        </li>
                        <li class="social-google"><a href="#" target="_blank"><i class="icon-google-plus-sign icon-2x"></i></a>
                        </li>
                        <li class="social-pinterest"><a href="#" target="_blank"><i class="icon-pinterest-sign icon-2x"></i></a>
                        </li>
                        <li class="social-instagram"><a href="#" target="_blank"><i class="icon-instagram icon-2x"></i></a>
                        </li>
                    </ul>
                </div>
            </div>
            <!-- /.conatiner -->
        </section>
    </div>
    <!-- core JavaScript
    ================================================== -->
    <script src="../Scripts/jquery.min.js"></script>
    <script src="../Scripts/overrides.js"></script>
    <!-- Just for debugging purposes. Don't actually copy these 2 lines! -->
    <!--[if lt IE 9]><script src="../Scripts/ie8-responsive-file-warning.js"></script><![endif]-->
    <script src="../Scripts/ie-emulation-modes-warning.js"></script>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="../Scripts/html5shiv.min.js"></script>
      <script src="../Scripts/respond.min.js"></script>
    <![endif]-->
    <script>
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
            m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

        ga('create', 'UA-57963702-1', 'auto');
        ga('send', 'pageview');
    </script>
    <script>
        $(document).ready(function () {            
            $("#blog-page").addClass("<%= this.strClass %>");
        });
    </script>
</body>
</html>


