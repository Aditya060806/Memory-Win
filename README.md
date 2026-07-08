<div align="center">

<img src="./docs/assets/images/memory-win.png" alt="Memory-Win" width="96" height="96" />

# Memory-Win

### A fast, transparent, native Windows RAM optimizer — no snake oil, just documented Windows APIs.

[![Windows](https://img.shields.io/badge/WINDOWS-XP%20%E2%80%93%2011-0078D6?style=for-the-badge&logo=windows&logoColor=white)](#-requirements)
[![Server](https://img.shields.io/badge/SERVER-2003%20%E2%80%93%202025-0078D6?style=for-the-badge&logo=windows&logoColor=white)](#-requirements)
[![.NET](https://img.shields.io/badge/.NET-4.0%20WPF-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](#-architecture)
[![License](https://img.shields.io/github/license/Aditya060806/Memory-Win?color=2ea44f&style=for-the-badge)](/LICENSE)
[![Dependencies](https://img.shields.io/badge/DEPENDENCIES-0-success?style=for-the-badge)](#-architecture)

<br/>

[**⬇️ Download / Build**](#-getting-started) · [**📊 Efficiency**](#-efficiency--benchmarks) · [**⚖️ Comparison**](#-how-it-compares) · [**🧬 How it works**](#-how-it-works) · [**🖥️ CLI**](#-command-line--automation)

<img src="./docs/assets/images/main-window.png" alt="Memory-Win main window" />

</div>

---

## 💡 What is Memory-Win?

**Memory-Win** is a free, open-source, **portable single-executable** utility that reclaims wasted RAM on Windows by calling the same **documented, native Windows APIs** the operating system uses internally — nothing hidden, nothing hacky.

It's built for the majority of real-world machines: the **8 GB laptop**, the **16 GB gaming rig**, and the developer juggling VMs and browser tabs. When apps hoard memory or the standby cache fills up, Memory-Win frees it **on demand** so your next task gets the RAM it needs.

> **Zero third-party dependencies. No installation. No telemetry. Runs from a single `.exe`.**

---

## ✨ Features

| Feature | What it does |
|:---|:---|
| 🧹 **One-click optimize** | Reclaim RAM instantly from 8 targeted memory areas. |
| 🌗 **Dark / Light theme** | Live-switching, persisted theme — modern look, zero lag. |
| 📈 **RAM-reclaimed statistics** | Tracks lifetime optimizations and **total memory reclaimed**, shown after every run. |
| ⏱️ **Auto-optimization** | Trigger by interval (every *X* hours) or when free RAM drops below a threshold. |
| ⌨️ **Global hotkey** | Optimize from anywhere (default `Ctrl + Shift + M`), toggleable. |
| 🔔 **Smart notifications** | See the reason and the amount of RAM freed after each run. |
| 🖥️ **Tray icon** | Live memory-usage readout, color thresholds, middle-click to optimize. |
| 🚫 **Process exclusion list** | Protect critical apps from working-set trimming. |
| 🪶 **Compact mode** | Collapse to a minimal at-a-glance monitor. |
| 🏃 **Run on startup / low priority** | Autostart via Task Scheduler; optional low-priority mode to avoid freezes. |
| 🧰 **Console & Service modes** | Silent CLI optimization and a background Windows Service. |
| 🌐 **30+ languages** | Full right-to-left (RTL) and bidirectional text support. |

---

## 📊 Efficiency & Benchmarks

Memory-Win converts **cached / hoarded** memory back into **truly free** memory. The charts below are **illustrative examples** measured with Windows Resource Monitor on a 16 GB system after closing a large game — *your results depend on your hardware and workload.*

**Physical RAM composition — before optimization**

```mermaid
pie showData
    title Physical RAM before (example, 16 GB)
    "In use" : 42
    "Standby / cached" : 38
    "Free" : 20
```

**RAM reclaimed per memory area (example)**

```mermaid
xychart-beta
    title "Approx. MB reclaimed by area after closing a game (16 GB system)"
    x-axis ["Standby List", "Working Set", "Modified Page List", "System File Cache", "Combined Page List"]
    y-axis "MB freed" 0 --> 4000
    bar [3200, 1400, 900, 600, 300]
```

**Free RAM: before vs after**

```mermaid
xychart-beta
    title "Free physical memory (example, 16 GB system)"
    x-axis ["Before", "After Memory-Win"]
    y-axis "Free RAM (GB)" 0 --> 12
    bar [3.2, 9.6]
```

> ✅ **Verify it yourself** — see the [Proof of Concept](#-proof-of-concept) below. Memory-Win never fabricates results; it shows exactly how much *free physical memory* changed, straight from the Windows API.

---

## ⚖️ How It Compares

|  | 🟢 **Memory-Win** | 🔴 Typical "RAM booster" | 🟡 Manual (Task Manager) |
|:---|:---:|:---:|:---:|
| Uses documented native Windows APIs | ✅ Yes | ❌ Undocumented tricks | ✅ Yes |
| Frees the **Standby List** (cached RAM) | ✅ Yes | ⚠️ Rarely | ❌ No |
| Trims **working sets** across processes | ✅ Yes | ⚠️ Sometimes | ❌ No (per-process only) |
| Open source & auditable | ✅ Yes | ❌ No | — |
| Third-party dependencies | ✅ **None** | ❌ Many / bundled ads | — |
| Portable single `.exe` | ✅ Yes | ❌ Installer + services | — |
| Telemetry / ads | ✅ **None** | ❌ Common | — |
| Automation (CLI / Service) | ✅ Yes | ⚠️ Limited | ❌ No |
| Cost | 🆓 Free | 💲 Freemium / paid | 🆓 Free |
| RAM footprint | 🪶 Tiny (native .NET 4.0) | 🐘 Heavy | — |

---

## 🧬 How It Works

Memory-Win is a friendly front-end for powerful, **documented Windows API functions**. Each cleaner targets a specific memory area; availability depends on your Windows version.

| Memory Area | Description | Windows | Server |
| :--- | :--- | :---: | :---: |
| **Combined&nbsp;Page&nbsp;List** | Flushes the page-combining list that merges identical memory pages. | 8+ | 2012+ |
| **Modified&nbsp;File&nbsp;Cache** | Flushes the volume file cache to disk for all fixed drives. | XP+ | 2003+ |
| **Modified&nbsp;Page&nbsp;List** | Writes unsaved pages to disk and moves them to the standby list. | Vista+ | 2008+ |
| **Registry&nbsp;Cache** | Flushes registry hives from memory. | 8.1+ | 2012+ |
| **Standby&nbsp;List** | Clears the entire standby list — the biggest source of reclaimable cached RAM. | Vista+ | 2008+ |
| **Standby&nbsp;List&nbsp;(low&nbsp;priority)** | Clears only the lowest-priority cached pages (gentler). | Vista+ | 2008+ |
| **System&nbsp;File&nbsp;Cache** | Trims the cache Windows uses for its own system files. | XP+ | 2003+ |
| **Working&nbsp;Set** | Forces processes to release non-essential RAM (reduces stutter). | XP+ | 2003+ |

---

## 🔬 Proof of Concept

Don't take our word for it — watch it work in **Resource Monitor**:

1. Open Resource Monitor (`resmon.exe`) → **Memory** tab.
2. Note the blue **Standby** bar (cached RAM from closed apps).
3. Open and close a few large apps (a game, a browser) and watch **Standby** grow.
4. In Memory-Win, select **only `Standby List`** and click **Optimize**.
5. Watch **Standby** drop and light-green **Free** rise by the same amount — instantly.

That's the whole trick: **cached memory becomes free memory**, verifiably.

---

## 🚀 Getting Started

Memory-Win needs **administrator privileges** to perform deep memory cleaning (it requests elevation automatically).

### Option A — Download a release

Grab the latest `MemoryWin.exe` from the [**Releases**](https://github.com/Aditya060806/Memory-Win/releases/latest) page, then right-click → **Run as administrator**. No installation required.

### Option B — Build from source (verified)

Requires **Visual Studio 2022 Build Tools** (MSBuild) and the **NuGet CLI**. This mirrors the CI pipeline exactly.

```powershell
# 1. Restore packages
nuget restore src\MemoryWin.sln

# 2. Build (Release). CI=true uses the NuGet .NET 4.0 reference assemblies
#    and skips the admin-only local bootstrap target.
& "C:\Program Files (x86)\Microsoft Visual Studio\2022\BuildTools\MSBuild\Current\Bin\MSBuild.exe" `
    src\MemoryWin.sln /p:Configuration=Release /p:Platform="Any CPU" /p:CI=true
```

Output: `src\bin\Release\MemoryWin.exe`.

```powershell
# 3. (Optional) Run the test suite against the build
src\packages\NUnit.Runners.2.6.4\tools\nunit-console.exe src\bin\Release\MemoryWin.exe
```

---

## 🖥️ Command-Line & Automation

Run these **as administrator**. Combine memory-area flags freely:

```cmd
MemoryWin.exe /StandbyList /WorkingSet /ModifiedFileCache
```

| Flag | Action |
|:---|:---|
| `/CombinedPageList` `/ModifiedFileCache` `/ModifiedPageList` `/RegistryCache` | Optimize that memory area |
| `/StandbyList` **or** `/StandbyListLowPriority` | Clear standby cache (full or gentle) |
| `/SystemFileCache` `/WorkingSet` | Optimize that memory area |
| `/Stats` | 🆕 Print lifetime stats (optimizations run + total RAM reclaimed) |
| `/Install` / `/Uninstall` | Install / remove the background **Windows Service** |
| `/Reset` | Restore factory defaults (keeps your language) |

**Example — scheduled silent cleanup:**

```cmd
"C:\Tools\MemoryWin.exe" /StandbyList /WorkingSet
```

**Example — check how much you've reclaimed:**

```cmd
"C:\Tools\MemoryWin.exe" /Stats
```

---

## 🌗 Themes & 📈 Statistics

- **Dark / Light theme** — toggle **Dark mode** in Settings. The switch is live and persisted to your profile; the whole UI re-themes instantly with no restart.
- **RAM-reclaimed statistics** — Memory-Win counts every optimization and the **total physical memory reclaimed** over the app's lifetime. The running total appears in the post-optimization notification and via the `/Stats` command. Statistics reset with `/Reset`.

---

## ⚙️ Settings & Storage

All settings and statistics are stored in the Windows registry at:

```
HKEY_LOCAL_MACHINE\SOFTWARE\MemoryWin
```

To wipe everything back to defaults, run `MemoryWin.exe /Reset` (see [Troubleshooting](#-troubleshooting)).

---

## 🧩 Requirements

- **OS:** Windows XP / Server 2003 and later (up to Windows 11 / Server 2025), 32- or 64-bit.
- **Runtime:** .NET Framework 4.0 (preinstalled on modern Windows).
- **Privileges:** Administrator (required for the memory-management APIs).

### 🏗️ Architecture

- **WPF + MVVM** single-page UI on the legacy **.NET Framework 4.0**.
- **Zero third-party runtime dependencies** — only native Windows APIs (`ntdll`, `psapi`, `kernel32`, `advapi32`).
- Hand-rolled IoC container, embedded-resource localization, and theming.
- Portable: everything ships in one signed executable.

---

## 🌐 Localization

Memory-Win ships in **30+ languages** with full RTL/bidirectional support. Language files live in [`src/Resources/Localization`](/src/Resources/Localization). New strings use an English baseline until a native translation is contributed — **PRs from native speakers are very welcome** (provide values in lowercase; the app capitalizes for display).

<details>
<summary>Supported languages</summary>

Albanian · Arabic · Bulgarian · Chinese (Simplified) · Chinese (Traditional) · Dutch · English · French · German · Greek · Hebrew · Hungarian · Indonesian · Irish · Italian · Japanese · Korean · Macedonian · Norwegian · Persian · Polish · Portuguese (Brazil) · Portuguese (Portugal) · Russian · Serbian · Slovenian · Spanish · Thai · Turkish · Ukrainian

</details>

---

## 🛠️ Troubleshooting

**Flagged by antivirus / SmartScreen?** New, unsigned builds have no reputation yet, and creating a startup scheduled task + registry entries can trigger heuristic false positives. Build from source or verify the release, then allow-list it.

**Reset to factory defaults** (fixes crashes / stuck windows):

```cmd
MemoryWin.exe /Reset
```

**View logs:** All activity is written to the Windows **Event Viewer** → `Windows Logs > Application`, source **Memory-Win**.

---

## 🤝 Contributing

Contributions are welcome — bug fixes, features, and especially **translations**. Please keep the project's principles intact: native APIs only, no third-party runtime dependencies, and Windows retro-compatibility.

## 📄 License

Released under the [GPL-3.0](/LICENSE) license.

<div align="center">

**Built with ❤️ by [Aditya Pandey](https://github.com/Aditya060806)**

⭐ If Memory-Win helps you, consider starring the repo!

</div>
