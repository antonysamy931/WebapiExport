using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleApiMobileValidator.Models
{    
    public class ResponseModel
    {
        public string kind { get; set; }
        public string id { get; set; }
        public int responseCode { get; set; }
        public string title { get; set; }
        public Rulegroups ruleGroups { get; set; }
        public Pagestats pageStats { get; set; }
        public Formattedresults formattedResults { get; set; }
        public Version version { get; set; }
        public Screenshot screenshot { get; set; }
    }

    public class Rulegroups
    {
        public SPEED SPEED { get; set; }
        public USABILITY USABILITY { get; set; }
    }

    public class SPEED
    {
        public int score { get; set; }
    }

    public class USABILITY
    {
        public int score { get; set; }
    }

    public class Pagestats
    {
        public int numberResources { get; set; }
        public int numberHosts { get; set; }
        public string totalRequestBytes { get; set; }
        public int numberStaticResources { get; set; }
        public string htmlResponseBytes { get; set; }
        public string cssResponseBytes { get; set; }
        public string imageResponseBytes { get; set; }
        public string javascriptResponseBytes { get; set; }
        public string otherResponseBytes { get; set; }
        public int numberJsResources { get; set; }
        public int numberCssResources { get; set; }
    }

    public class Formattedresults
    {
        public string locale { get; set; }
        public Ruleresults ruleResults { get; set; }
    }

    public class Ruleresults
    {
        public Avoidlandingpageredirects AvoidLandingPageRedirects { get; set; }
        public Avoidplugins AvoidPlugins { get; set; }
        public Configureviewport ConfigureViewport { get; set; }
        public Enablegzipcompression EnableGzipCompression { get; set; }
        public Leveragebrowsercaching LeverageBrowserCaching { get; set; }
        public Mainresourceserverresponsetime MainResourceServerResponseTime { get; set; }
        public Minifycss MinifyCss { get; set; }
        public Minifyhtml MinifyHTML { get; set; }
        public Minifyjavascript MinifyJavaScript { get; set; }
        public Minimizerenderblockingresources MinimizeRenderBlockingResources { get; set; }
        public Optimizeimages OptimizeImages { get; set; }
        public Prioritizevisiblecontent PrioritizeVisibleContent { get; set; }
        public Sizecontenttoviewport SizeContentToViewport { get; set; }
        public Sizetaptargetsappropriately SizeTapTargetsAppropriately { get; set; }
        public Uselegiblefontsizes UseLegibleFontSizes { get; set; }
    }

    public class Avoidlandingpageredirects
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary summary { get; set; }
    }

    public class Summary
    {
        public string format { get; set; }
        public Arg[] args { get; set; }
    }

    public class Arg
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Avoidplugins
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary1 summary { get; set; }
    }

    public class Summary1
    {
        public string format { get; set; }
        public Arg1[] args { get; set; }
    }

    public class Arg1
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Configureviewport
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary2 summary { get; set; }
    }

    public class Summary2
    {
        public string format { get; set; }
        public Arg2[] args { get; set; }
    }

    public class Arg2
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Enablegzipcompression
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary3 summary { get; set; }
    }

    public class Summary3
    {
        public string format { get; set; }
        public Arg3[] args { get; set; }
    }

    public class Arg3
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Leveragebrowsercaching
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary4 summary { get; set; }
        public Urlblock[] urlBlocks { get; set; }
    }

    public class Summary4
    {
        public string format { get; set; }
    }

    public class Urlblock
    {
        public Header header { get; set; }
        public Url[] urls { get; set; }
    }

    public class Header
    {
        public string format { get; set; }
        public Arg4[] args { get; set; }
    }

    public class Arg4
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Url
    {
        public Result result { get; set; }
    }

    public class Result
    {
        public string format { get; set; }
        public Arg5[] args { get; set; }
    }

    public class Arg5
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Mainresourceserverresponsetime
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary5 summary { get; set; }
    }

    public class Summary5
    {
        public string format { get; set; }
        public Arg6[] args { get; set; }
    }

    public class Arg6
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Minifycss
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary6 summary { get; set; }
    }

    public class Summary6
    {
        public string format { get; set; }
        public Arg7[] args { get; set; }
    }

    public class Arg7
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Minifyhtml
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary7 summary { get; set; }
    }

    public class Summary7
    {
        public string format { get; set; }
        public Arg8[] args { get; set; }
    }

    public class Arg8
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Minifyjavascript
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary8 summary { get; set; }
    }

    public class Summary8
    {
        public string format { get; set; }
        public Arg9[] args { get; set; }
    }

    public class Arg9
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Minimizerenderblockingresources
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary9 summary { get; set; }
    }

    public class Summary9
    {
        public string format { get; set; }
        public Arg10[] args { get; set; }
    }

    public class Arg10
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Optimizeimages
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary10 summary { get; set; }
    }

    public class Summary10
    {
        public string format { get; set; }
        public Arg11[] args { get; set; }
    }

    public class Arg11
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Prioritizevisiblecontent
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary11 summary { get; set; }
    }

    public class Summary11
    {
        public string format { get; set; }
        public Arg12[] args { get; set; }
    }

    public class Arg12
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Sizecontenttoviewport
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary12 summary { get; set; }
    }

    public class Summary12
    {
        public string format { get; set; }
        public Arg13[] args { get; set; }
    }

    public class Arg13
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Sizetaptargetsappropriately
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary13 summary { get; set; }
    }

    public class Summary13
    {
        public string format { get; set; }
        public Arg14[] args { get; set; }
    }

    public class Arg14
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Uselegiblefontsizes
    {
        public string localizedRuleName { get; set; }
        public float ruleImpact { get; set; }
        public string[] groups { get; set; }
        public Summary14 summary { get; set; }
    }

    public class Summary14
    {
        public string format { get; set; }
        public Arg15[] args { get; set; }
    }

    public class Arg15
    {
        public string type { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Version
    {
        public int major { get; set; }
        public int minor { get; set; }
    }

    public class Screenshot
    {
        public string mime_type { get; set; }
        public string data { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Page_Rect page_rect { get; set; }
    }

    public class Page_Rect
    {
        public int left { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

}