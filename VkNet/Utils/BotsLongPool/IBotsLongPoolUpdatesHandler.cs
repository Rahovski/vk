﻿#nullable enable
using System.Threading;
using System.Threading.Tasks;

namespace VkNet.Utils.BotsLongPool;

/// <summary>
/// Обработчик лонгпула групповых сообщений
/// </summary>
public interface IBotsLongPoolUpdatesHandler
{
	/// <summary>
	/// Запуск отслеживания событий
	/// </summary>
	/// <param name="token">Токен отмены операции</param>
	Task RunAsync(CancellationToken token = default);
}