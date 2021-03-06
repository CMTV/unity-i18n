namespace CMTV.I18n.EditorUtilities
{
    public class Path
    {
        const string UXML_PATH = "Packages/com.cmtv.i18n/Editor Resources/uxml/";
        const string USS_PATH = "Packages/com.cmtv.i18n/Editor Resources/uss/";
        const string TEXTURE_PATH = "Packages/com.cmtv.i18n/Editor Resources/Gizmos/";

        public static string UXML(string name)
        {
            return UXML_PATH + name + ".uxml";
        }

        public static string USS(string name)
        {
            return USS_PATH + name +  ".uss";
        }

        public static string Texture(string name)
        {
            return TEXTURE_PATH + name;
        }
    }
}