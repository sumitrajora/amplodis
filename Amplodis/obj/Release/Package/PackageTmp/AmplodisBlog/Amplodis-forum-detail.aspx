<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Amplodis-forum-detail.aspx.cs" Inherits="Amplodis.AmplodisBlog.Amplodis_forum_detail" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="images/favicon.ico">

    <title>Climb UP</title>


    <link href="../css/web-global.css" rel="stylesheet">
    <link href="../font-awesome/css/font-awesome.css" rel="stylesheet">
</head>

<body>
    <form runat="server">
        <div id="page1" class="gd-row page1">

            <div id="navbar" class="gd-container ws-clearfix">
                <!--<a id="touch-menu" class="mobile-menu" href="#"><i class="icon-reorder"></i>Menu</a> -->

                <div class="navbar-brand">
                    <a class="navbar-logo" href="https://www.amplodis.com">
                        <img alt="logo" src="../images/amplodis-logo-white.png">
                    </a>
                </div>
                <nav>
                    <a id="touch-menu" class="mobile-menu" href="#"><i class="icon-reorder"></i>Menu</a>
                    <ul class="menu">
                        <li><a href="#"><i class="icon-home"></i>Home</a></li>
                        <li><a href="#"><i class="icon-user"></i>About Us</a></li>
                        <li><a href="#"><i class="icon-cog"></i>Services</a>
                            <ul class="sub-menu">
                                <li><a href="#">Sub-Menu 1</a></li>
                                <li><a href="#">Level 3 Menu</a>
                                    <ul>
                                        <li><a href="#">Sub-Menu 4</a></li>
                                        <li><a href="#">Sub-Menu 5</a></li>
                                        <li><a href="#">Sub-Menu 6</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                        <li><a href="#"><i class="icon-bullhorn"></i>Blog</a></li>
                        <li><a href="#"><i class="icon-envelope-alt"></i>Contact</a></li>
                    </ul>
                </nav>


            </div>
            <!--end mainWrap-->



        </div>



        <div id="blog-page" class="gd-row blog-page all-blog">
            <div class="gd-container ws-clearfix blog-content"><!--
                <a class="category-btn all-blog-btn" href="http://www.amplodis.com/about-us.html">All Blogs</a>
                <a class="category-btn ui-dev-btn" href="http://www.amplodis.com/about-us.html">UI Development</a>
                <a class="category-btn mobile-dev-btn" href="http://www.amplodis.com/about-us.html">Mobile Application</a>
                <a class="category-btn product-dev-btn" href="http://www.amplodis.com/about-us.html">Product</a>
                <a class="category-btn social-media-dev-btn" href="http://www.amplodis.com/about-us.html">Social Media</a> -->
                <div class="articledetail">
                    <div class="datewritten"><asp:Label ID="lblDate" runat="server"></asp:Label></div>
                    <h1 class="header-text"><asp:Label ID="lblBlogName" runat="server"></asp:Label></h1>
                    <div class="date-title">
                        <div class="vcard-picture">
                            <img runat="server" id="imgUser" class="" alt="" >
                        </div>
                        <div class="details">
                            <div class="categories">in <a rel="category tag" title="View all posts in Software Development" href="#" class="brand-link"><asp:Label ID="lblTagName" runat="server"></asp:Label></a></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div id="page8" class="gd-row page8">
            <div class="gd-container ws-clearfix blog-content">
                <article class="blog-artical tag-software-development">
                    <div class="even">
                        <header class="clearfix">
                            <div class="summaryofblog">
                                <p><asp:Label ID="lblDesc" runat="server"></asp:Label></p>
                            </div>
                        </header>
                    </div>
                </article>


            </div>

        </div>


        <!-- /.footer-Meta -->
        <div class="gd-row">
            <section class="footer-meta">
                <div class="gd-container">
                    <div class="gd-grid-12">
                        <p class="copyright-area">CopyRight 2014 <a href="#" class="brand-link">amplodis</a> .  All Rights Reserved. Creative by <a href="http://www.amplodis.com" class="brand-link"><b>amplodis @creative</b></a></p>
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
        <script src="js/jquery.min.js"></script>
        <script src="js/overrides.js"></script>

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
    </form>
</body>
</html>
