using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Filmes.Models;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Filmes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly HttpClient _httpClient; // Adicionado HttpClient como campo privado
    private readonly string _apiKey = "e626f31fa6b34557eb711628d474d831"; // Chave de API

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _httpClient = new HttpClient { BaseAddress = new Uri("https://api.themoviedb.org/3/") }; // Inicialização do HttpClient
    }

    public async Task<IActionResult> Index()
    {
        try
        {
            // Faz a requisição para a API
            var response = await _httpClient.GetAsync($"movie/popular?api_key={_apiKey}&language=pt-BR");
            response.EnsureSuccessStatusCode();

            response.EnsureSuccessStatusCode(); // Verifica se a resposta foi bem-sucedida
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var movies = JObject.Parse(jsonResponse)["results"]; // Extrai os filmes populares

            // Envia os dados para a View
            return View(movies);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao buscar os dados da API.");
            return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public async Task<IActionResult> Search(string query)
    {
        try
        {
            // Requisição para buscar um filme pelo título
            var response = await _httpClient.GetAsync($"search/movie?api_key={_apiKey}&language=pt-BR&query={query}");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var movies = JObject.Parse(jsonResponse)["results"]; // Pega os resultados

            return View("Results", movies); // Exibe na View Results
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao buscar filmes.");
            return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public async Task<IActionResult> Filter(string genre)
    {
        try
        {
            // Requisição para filtrar filmes pelo gênero
            var response = await _httpClient.GetAsync($"discover/movie?api_key={_apiKey}&language=pt-BR&with_genres={genre}");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var movies = JObject.Parse(jsonResponse)["results"]; // Pega os resultados

            return View("Results", movies); // Exibe na View Results
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao filtrar filmes.");
            return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}