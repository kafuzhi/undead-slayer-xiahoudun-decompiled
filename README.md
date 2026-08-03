# 亡灵杀手：夏侯惇 - 反编译源码 (Undead Slayer: Xiahou Dun Decompiled Source)

## 项目说明

本项目包含从《亡灵杀手：夏侯惇》Android APK (v3.5.0) 反编译得到的 C# 源代码和游戏资源。

**原始APK信息：**
- 包名：`com.nhncorp.skundeadck`
- 版本：3.5.0 (versionCode: 36)
- Unity版本：4.5.4f1
- 架构：armeabi-v7a (32-bit ARM)
- 最低SDK：Android 2.3.3 (API 10)

## 目录结构

```
├── Assets/
│   ├── Scripts/           # 反编译的C#源代码 (338个文件)
│   │   ├── *.cs           # 游戏逻辑类
│   │   ├── LitJson/       # JSON解析库
│   │   └── MiniJSON/      # MiniJSON库
│   ├── Resources/         # Unity资源文件
│   │   ├── *.assets       # Unity资产包
│   │   ├── *.split*       # 分割的资产文件
│   │   ├── Managed/       # .NET程序集
│   │   └── Data/          # 游戏数据
│   ├── Textures/          # 贴图资源
│   ├── Audio/             # 音频资源
│   ├── Models/            # 3D模型
│   ├── Animations/        # 动画
│   └── Prefabs/           # 预制体
├── ProjectSettings/       # Unity项目设置
├── lib/                   # 原始native库 (armeabi-v7a)
└── README.md
```

## 主要类说明

### 游戏核心
- `Cha_Control` - 角色控制
- `Cha_Skill` - 技能系统
- `Cha_Weapon` - 武器系统
- `Cha_Costume` - 服装系统

### AI系统
- `AI_Boss01` - Boss AI
- `AI_Enemy01` - 普通敌人AI
- `AI_General` - 通用AI
- `AI_Ride_Enemy` - 骑乘敌人AI

### UI系统
- `UI_Ingame` - 游戏内UI
- `UI_map` - 地图UI
- `UI_status` - 状态UI
- `UI_forge` - 锻造UI
- `UI_skill` - 技能UI

### 数据管理
- `DB_Boss` - Boss数据
- `DB_Monster` - 怪物数据
- `DB_Weapon` - 武器数据
- `DB_Stage` - 关卡数据
- `DataSave` - 存档系统

### 战斗系统
- `Bullet_*` - 各种子弹/投射物
- `WeaponDamage` - 武器伤害
- `MonsterHit` - 怪物受击

## 如何使用

### 重建64位版本

1. **安装Unity** (推荐2021.3 LTS或更高版本)
2. **打开项目**：在Unity中打开本项目文件夹
3. **修复编译错误**：由于Unity版本差异(4.x → 2021+)，部分API可能需要调整
4. **设置构建目标**：File → Build Settings → Android
5. **配置Player Settings**：
   - Scripting Backend: IL2CPP
   - Target Architectures: ARM64 (勾选)
6. **构建APK**：Build

### 常见Unity 4.x → 2021+ 迁移问题

- `Application.LoadLevel()` → `SceneManager.LoadScene()`
- `GameObject.FindWithTag()` 返回值可能变化
- 部分GUI API已弃用，需改用UI系统
- `MovieTexture` → `VideoPlayer`

## 免责声明

本项目仅用于学习和研究目的。所有原始代码和资源的版权归原始开发者NHN Corp所有。请勿用于商业用途。

## 技术细节

反编译工具：自定义Python脚本 + dnfile库
反编译内容：Assembly-CSharp.dll (940KB, 339类型, 2013方法)
