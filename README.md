# AstraAOI

AstraAOI is a modular AOI visual inspection system designed to support industrial camera image capture, defect analysis, result judgment, and process integration, while offering excellent maintainability and scalability.

```
AstraAOI/
├── SharedLibraries/               # 共用邏輯（狀態機、工具類別）
│   └── StateMachine/
│   └── Utilities/
└── AstraAOI/
    ├── CameraControl/             # 攝影機控制模組（Basler SDK 封裝）
    ├── ImageProcessing/           # 影像前處理模組（OpenCV、濾波、ROI）
    ├── DefectDetection/           # 瑕疵分析模組（模板比對、輪廓分析）
    ├── Classification/            # 結果判斷模組（OK / NG / 疑似）
    ├── UI/                        # 使用者介面（WinForms / WPF）
    ├── Logging/                   # 資料儲存與紀錄（Log、JSON、MQTT）
    ├── AutoProcessIntegration/    # 與 AutoProcess 模組整合（流程節點）
    ├── Resources/                 # 多語系與影像資源
    ├── Tests/                     # 單元測試與模擬測試
    └── AstraAOI.csproj            # 專案設定檔（.NET SDK 8.0）
```

## Development Environment

- OS：Windows 10 x64

- IDE：Microsoft Visual Studio Professional 2019

- SDK：

  - .NET SDK 8.0.413

  - Basler pylon 7.5.0（支援虛擬相機模擬）

  - Epson RC+ 7.0（機器手臂模擬）

## Test method

Currently, image capture simulation is being performed using Basler pylon's virtual camera function. Image processing and defect analysis modules will be gradually integrated and tested with the AutoProcess process node.

## Module progress tracking

|Module| Status| Notes|
|------|-------|------|
|CameraControl |Initial packaging completed.|Testing with a virtual camera.|
|ImageProcessing| Under development.|ROI and filtering logic design in progress.|
|DefectDetection| Not yet started.|Expected to use template comparison and contour analysis.|
|UI| Not yet started.|Expected to use WinForms.|
|Logging|Not yet started.|Expected to support JSON and MQTT.|
|AutoProcessIntegration|Not yet started.|AOI process node interface to be designed.|


