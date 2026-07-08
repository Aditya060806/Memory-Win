### 1.0.0

**2026-07-09**

First public release of **Memory-Win** — a fast, transparent, native Windows RAM optimizer with zero third-party dependencies.

**Highlights**

- Reclaim RAM on demand from 8 targeted memory areas (Combined Page List, Modified File Cache, Modified Page List, Registry Cache, Standby List, Standby List Low Priority, System File Cache, Working Set) using documented native Windows APIs.
- 🌗 **Dark / Light theme** — live-switching and persisted.
- 📈 **RAM-reclaimed statistics** — tracks lifetime optimizations and total memory reclaimed, shown after every optimization.
- 🖥️ **`/Stats` command-line** — print lifetime statistics for automation and scripting.
- ⏱️ Auto-optimization by interval or when free memory drops below a threshold.
- ⌨️ Global optimization hotkey (default `Ctrl + Shift + M`), toggleable.
- 🔔 System-tray icon with live memory usage, color thresholds, and middle-click optimize.
- 🚫 Process exclusion list, compact mode, run on startup, run on low priority.
- 🧰 Console (silent) mode and background Windows Service mode.
- 🌐 30+ languages with full right-to-left (RTL) and bidirectional text support.
- Portable single executable — no installation, no telemetry.

**Supported platforms**

- Windows XP / Server 2003 and later, up to Windows 11 / Server 2025 (32- and 64-bit).
- .NET Framework 4.0. Administrator privileges required for deep memory cleaning.
