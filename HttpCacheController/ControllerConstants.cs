namespace HttpCacheController;

public static class ControllerConstants
{
    public static string ANNOTATION_ENABLED_VALUE = "true";
    public static string ANNOTATION_AUTOGEN_VALUE = "true";
    public static string ANNOTATION_ENABLED = "swisstxt.ch/http-cache-enabled";
    public static string ANNOTATION_TARGET = "swisstxt.ch/http-cache-target";
    public static string ANNOTATION_AUTOGEN = "swisstxt.ch/http-cache-autogen";
    public static string CONFIG_MAP_NAME = "http-cache-config";
    public static string SERVICE_NAME_SUFFIX = "-cached";
    public static string NGINX_CONFIG_KEY = "nginx.conf";
}