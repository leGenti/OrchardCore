using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.OriginalsTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineStyle("TheTheme-bootstrap-oc")
                .SetUrl("~/TheTheme/css/bootstrap-oc.min.css", "~/TheTheme/css/bootstrap-oc.css")
                .SetVersion("1.0.0");

            manifest
                .DefineStyle("MyStyle")
                .SetUrl("~/OriginalsTheme/css/MyStyle.min.css", "~/OriginalsTheme/css/MyStyle.css")
                .SetVersion("1.0.0");

            manifest
                .DefineScript("MyScript")
                .SetUrl("~/OriginalsTheme/js/MyScript.min.js", "~/OriginalsTheme/js/MyScript.js")
                .SetDependencies("jQuery")
                .SetVersion("1.0.0");

            manifest
                .DefineStyle("animate")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css")
                .SetVersion("1.0.0");

            manifest
                .DefineStyle("AOSstyle")
                .SetCdn("https://unpkg.com/aos@2.3.1/dist/aos.css")
                .SetVersion("1.0.0");

            manifest
                .DefineScript("AOSscript")
                .SetCdn("https://unpkg.com/aos@2.3.1/dist/aos.js")
                .SetVersion("1.0.0");

        }
    }
}
