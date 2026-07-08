// This file is used by Code Analysis to maintain SuppressMessage attributes that are applied to this project.

using System.Diagnostics.CodeAnalysis;

// General suppressions
[assembly: SuppressMessage("Design", "CA1030:Use events where appropriate", Justification = "Ignored", Scope = "type", Target = "~T:MemoryWin.ObservableObject")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Ignored")]
[assembly: SuppressMessage("Design", "CA1034:Nested types should not be visible", Justification = "Ignored")]
[assembly: SuppressMessage("Design", "CA1040:Avoid empty interfaces", Justification = "Ignored")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Ignored", Scope = "type", Target = "~T:MemoryWin.TrayIconContextMenuControl.ToolStripRenderer")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Ignored", Scope = "type", Target = "~T:MemoryWin.ExtensionMethods")]
[assembly: SuppressMessage("Documentation", "CA1200:Avoid using cref tags with a prefix", Justification = "Ignored")]
[assembly: SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "Ignored", Scope = "type", Target = "~T:MemoryWin.Localizer")]
[assembly: SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Ignored", Scope = "type", Target = "~T:MemoryWin.Constants")]
[assembly: SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Ignored", Scope = "type", Target = "~T:MemoryWin.Localizer")]
[assembly: SuppressMessage("Naming", "CA1724:Type names should not match namespaces", Justification = "Ignored", Scope = "type", Target = "~T:MemoryWin.Structs")]
[assembly: SuppressMessage("Performance", "CA1815:Override equals and operator equals on value types", Justification = "Ignored", Scope = "type", Target = "~T:MemoryWin.Structs")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Ignored")]
[assembly: SuppressMessage("Reliability", "CA9998:Migrate from FxCop analyzers to .NET analyzers", Justification = "Legacy .NET Framework version")]

// Test suppressions
[assembly: SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "Test classes implement IDisposable through IClassFixture/ICollectionFixture when needed", Scope = "type", Target = "~T:MemoryWin.ServiceTests+ComputerServiceTests")]
[assembly: SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "Test classes implement IDisposable through IClassFixture/ICollectionFixture when needed", Scope = "type", Target = "~T:MemoryWin.ServiceTests+HotkeyServiceTests")]
[assembly: SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "Test classes implement IDisposable through IClassFixture/ICollectionFixture when needed", Scope = "type", Target = "~T:MemoryWin.ServiceTests+NotificationServiceTests")]
[assembly: SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "Test classes implement IDisposable through IClassFixture/ICollectionFixture when needed", Scope = "type", Target = "~T:MemoryWin.ViewModelTests+MainViewModelTests")]
[assembly: SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "Test classes implement IDisposable through IClassFixture/ICollectionFixture when needed", Scope = "type", Target = "~T:MemoryWin.ViewModelTests+MessageViewModelTests")]
[assembly: SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "Test classes implement IDisposable through IClassFixture/ICollectionFixture when needed", Scope = "type", Target = "~T:MemoryWin.ViewModelTests+DonationViewModelTests")]
[assembly: SuppressMessage("Design", "CA1052:Static holder types should be static or NotInheritable", Justification = "Test container classes for organizing nested test classes", Scope = "type", Target = "~T:MemoryWin.ServiceTests")]
[assembly: SuppressMessage("Design", "CA1052:Static holder types should be static or NotInheritable", Justification = "Test container classes for organizing nested test classes", Scope = "type", Target = "~T:MemoryWin.ViewModelTests")]
[assembly: SuppressMessage("Design", "CA1812:Avoid uninstantiated internal classes", Justification = "Test helper classes", Scope = "namespaceanddescendants", Target = "~N:MemoryWin")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Test method names use underscores for readability following best naming conventions", Scope = "namespaceanddescendants", Target = "~N:MemoryWin")]