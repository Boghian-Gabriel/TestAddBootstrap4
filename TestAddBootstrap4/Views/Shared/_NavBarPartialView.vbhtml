@*<div class="navbar navbar-inverse navbar-fixed-top">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            @Html.ActionLink("Application name", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
        </div>
        <div class="navbar-collapse collapse">
            <ul class="nav navbar-nav">
                <li>@Html.ActionLink("Home", "Index", "Home")</li>
                <li>@Html.ActionLink("About", "About", "Home")</li>
                <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
            </ul>
        </div>
    </div>
</div>*@


<nav class="navbar navbar-expand-sm navbar-dark fixed-top bg-dark">
    <div class="container">
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
        </button>
        @Html.ActionLink("INFOPRIM", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
        <div class="navbar-collapse collapse" id="navbarSupportedContent">
            <ul class="nav navbar-nav">
                <li class="nav-item">@Html.ActionLink("Home", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})</li>
                <li class="nav-item">@Html.ActionLink("About", "About", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})</li>
                <li class="nav-item">@Html.ActionLink("Contact", "Contact", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})</li>
        </div>
    </div>
</nav>
