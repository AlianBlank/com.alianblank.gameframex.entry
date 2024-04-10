﻿using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取游戏基础组件。
    /// </summary>
    public static BaseComponent Base
    {
        get
        {
            if (_base == null)
            {
                _base = GameEntry.GetComponent<BaseComponent>();
            }

            return _base;
        }
    }

    private static BaseComponent _base;

    /// <summary>
    /// 获取配置组件。
    /// </summary>
    public static ConfigComponent Config
    {
        get
        {
            if (_config == null)
            {
                _config = GameEntry.GetComponent<ConfigComponent>();
            }

            return _config;
        }
    }

    private static ConfigComponent _config;

    /// <summary>
    /// 获取实体组件。
    /// </summary>
    public static EntityComponent Entity
    {
        get
        {
            if (_entity == null)
            {
                _entity = GameEntry.GetComponent<EntityComponent>();
            }

            return _entity;
        }
    }

    private static EntityComponent _entity;

    /// <summary>
    /// 获取事件组件。
    /// </summary>
    public static EventComponent Event
    {
        get
        {
            if (_event == null)
            {
                _event = GameEntry.GetComponent<EventComponent>();
            }

            return _event;
        }
    }

    private static EventComponent _event;

    /// <summary>
    /// 获取本地化组件。
    /// </summary>
    public static LocalizationComponent Localization
    {
        get
        {
            if (_localization == null)
            {
                _localization = GameEntry.GetComponent<LocalizationComponent>();
            }

            return _localization;
        }
    }

    private static LocalizationComponent _localization;

    /// <summary>
    /// 获取网络组件。
    /// </summary>
    public static NetworkComponent Network
    {
        get
        {
            if (_network == null)
            {
                _network = GameEntry.GetComponent<NetworkComponent>();
            }

            return _network;
        }
    }

    private static NetworkComponent _network;

    /// <summary>
    /// 获取对象池组件。
    /// </summary>
    public static ObjectPoolComponent ObjectPool
    {
        get
        {
            if (_objectPool == null)
            {
                _objectPool = GameEntry.GetComponent<ObjectPoolComponent>();
            }

            return _objectPool;
        }
    }

    private static ObjectPoolComponent _objectPool;

    /// <summary>
    /// 获取场景组件。
    /// </summary>
    public static SceneComponent Scene
    {
        get
        {
            if (_scene == null)
            {
                _scene = GameEntry.GetComponent<SceneComponent>();
            }

            return _scene;
        }
    }

    private static SceneComponent _scene;

    /// <summary>
    /// 获取声音组件。
    /// </summary>
    public static SoundComponent Sound
    {
        get
        {
            if (_sound == null)
            {
                _sound = GameEntry.GetComponent<SoundComponent>();
            }

            return _sound;
        }
    }

    private static SoundComponent _sound;

    /// <summary>
    /// 获取网络组件。
    /// </summary>
    // public static WebRequestComponent WebRequest
    // {
    //     get
    //     {
    //         if (_webRequest)
    //         {
    //             _webRequest = GameEntry.GetComponent<WebRequestComponent>();
    //         }
    //
    //         return _webRequest;
    //     }
    // }
    //
    // private static WebRequestComponent _webRequest;

    /// <summary>
    /// 获取UI组件。
    /// </summary>
    public static FUIComponent UI
    {
        get
        {
            if (_ui == null)
            {
                _ui = GameEntry.GetComponent<FUIComponent>();
            }

            return _ui;
        }
    }

    private static FUIComponent _ui;


    /// <summary>
    /// 获取UI包管理组件。
    /// </summary>
    public static FUIPackageComponent UIPackage
    {
        get
        {
            if (_fUIPackage == null)
            {
                _fUIPackage = GameEntry.GetComponent<FUIPackageComponent>();
            }

            return _fUIPackage;
        }
    }

    private static FUIPackageComponent _fUIPackage;


    /// <summary>
    /// 获取Asset组件。
    /// </summary>
    public static AssetComponent Asset
    {
        get
        {
            if (_asset == null)
            {
                _asset = GameEntry.GetComponent<AssetComponent>();
            }

            return _asset;
        }
    }

    private static AssetComponent _asset;


    /// <summary>
    /// 获取Lua组件。
    /// </summary>
    public static LuaComponent Lua
    {
        get
        {
            if (_lua == null)
            {
                _lua = GameEntry.GetComponent<LuaComponent>();
            }

            return _lua;
        }
    }

    private static LuaComponent _lua;
}