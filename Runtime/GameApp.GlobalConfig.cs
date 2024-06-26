﻿#if ENABLE_GAME_FRAME_X_GLOBAL_CONFIG
using GameFrameX.Runtime;
using GameFrameX.GlobalConfig.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取全局配置组件。
    /// </summary>
    public static GlobalConfigComponent GlobalConfig
    {
        get
        {
            if (_globalConfig == null)
            {
                _globalConfig = GameEntry.GetComponent<GlobalConfigComponent>();
            }

            return _globalConfig;
        }
    }

    private static GlobalConfigComponent _globalConfig;
}
#endif
