@Model IEnumerable<BBlog.Models.Makale>
    @foreach (BBlog.Models.Makale makale in Model)
    {
    <div class="blog-meta big-meta col-md-8">
        <h4><a href="tech-single.html" title="">@makale.Baslik</a></h4>
        <p>@makale.Icerik.Substring(0, 300)</p>
        <small class="firstsmall"><a class="bg-orange" href="tech-category-01.html" title="">Gadgets</a></small>
        <small><a href="tech-single.html" title="">@makale.EklenmeTarihi.ToShortDateString()</a></small>
        <small><a href="tech-author.html" title="">@makale.Yorums.Count</a></small>
        <small><a href="tech-single.html" title=""><i class="fa fa-eye"></i> 1114</a></small>
    </div><!-- end meta -->
    </div><!-- end blog-box -->

    

 }
    </div><!-- end blog-list -->
    </div>
    <!-- end page-wrapper --
    </BBlog.Models.Makale>
