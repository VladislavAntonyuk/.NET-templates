# .NET Templates

[![Buy Me A Coffee](https://ik.imagekit.io/VladislavAntonyuk/vladislavantonyuk/misc/bmc-button.png)](https://www.buymeacoffee.com/vlad.antonyuk)

[![Stand With Ukraine](https://img.shields.io/badge/made_in-ukraine-ffd700.svg?labelColor=0057b7)](https://stand-with-ukraine.pp.ua)

<a href="https://www.nuget.org/packages/VladislavAntonyuk.DotNetTemplates"><img src="https://img.shields.io/nuget/v/VladislavAntonyuk.DotNetTemplates?color=blue&style=flat-square&logo=nuget"></a>
<a href="https://www.nuget.org/packages/VladislavAntonyuk.DotNetTemplates"><img src="https://img.shields.io/nuget/dt/VladislavAntonyuk.DotNetTemplates.svg?style=flat-square"></a>

## Onion Architecture Templates

### Onion Architecture Cross-Platform Application

Cross-platform application (Blazor Server WebApp + .NET MAUI) with onion archirecture.

Create project:

```pwsh
dotnet new onion-app -n MyProjectName --entityName MyEntityName
```

### Onion Architecture Blazor Server Application

Blazor Server application with onion archirecture.

Create project:

```pwsh
dotnet new onion-blazor-server -n MyProjectName --entityName MyEntityName
```

### Onion Architecture Blazor WebAssembly Application

Blazor WebAssembly application with onion archirecture.

Create project:

```pwsh
dotnet new onion-blazor-webassembly -n MyProjectName --entityName MyEntityName
```

### Onion Architecture .NET MAUI Application

.NET MAUI application with onion archirecture.

Create project:

```pwsh
dotnet new onion-maui -n MyProjectName --entityName MyEntityName
```

## iOS Extensions for .NET MAUI Application

### Action Extension

iOS Action Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-action-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-ActionExtension`.

### Audio Unit Extension

iOS Audio Unit Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-audio-unit-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-AudioUnitExtension`.

### Broadcast UI Extension

iOS Broadcast UI Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-broadcast-ui-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-BroadcastUIExtension`.

### CallDirectory Extension

iOS Call Directory Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-call-directory-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-CallDirectoryExtension`.

### Content Blocker Extension

iOS Content Blocker Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-content-blocker-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-ContentBlockerExtension`.

### Custom Keyboard Extension

iOS Custom Keyboard Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-custom-keyboard-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-CustomKeyboardExtension`.

### Document Picker File Provider Extension

iOS Document Picker Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-document-picker-file-provider-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-DocumentPickerFileProviderExtension`.

### iMessage Extension

iOS iMessage Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-imessage-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-IMessageExtension`.

### Intents UI Extension

iOS Intents UI Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-intents-ui-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-IntentsUIExtension`.

### Notification Content Extension

iOS Notification Content Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-notification-content-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-NotificationContentExtension`.

### Notification Service Extension

iOS Notification Service Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-notification-service-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-NotificationServiceExtension`.

### Photo Editing Extension

iOS Photo Editing Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-photo-editing-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-PhotoEditingExtension`.

### Shared Links Extension

iOS Shared Links Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-shared-links-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-SharedLinksExtension`.

### Share Extension

iOS Share Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-share-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-ShareExtension`.

### Spotlight Index Extension

iOS Spotlight Index Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-spotlight-index-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-SpotlightIndexExtension`.

### Today Extension

iOS Today Extension for .NET MAUI application.

Create project:

```pwsh
dotnet new ios-today-extension -n MyProjectName --applicationId com.vladislavantonyuk.myapp.myapp
```

The final application id: `com.vladislavantonyuk.myapp.myapp-TodayExtension`.

## Build 

```pwsh
dotnet pack
```

## Install Templates

From NuGet:

```pwsh
dotnet new install VladislavAntonyuk.DotNetTemplates
```

From file:

```pwsh
dotnet new install VladislavAntonyuk.DotNetTemplates.2.0.0.nupkg
```

## Uninstall

```pwsh
dotnet new uninstall VladislavAntonyuk.DotNetTemplates
```

[![Buy Me A Coffee](https://ik.imagekit.io/VladislavAntonyuk/vladislavantonyuk/misc/bmc-button.png)](https://www.buymeacoffee.com/vlad.antonyuk)

[![Stand With Ukraine](https://img.shields.io/badge/made_in-ukraine-ffd700.svg?labelColor=0057b7)](https://stand-with-ukraine.pp.ua)