document.addEventListener("DOMContentLoaded", function () {
  var backgroundMusic = document.getElementById("backgroundMusic");
  var musicaUrl = localStorage.getItem("musicaUrl");
  var playPauseBtn = document.getElementById("playPauseBtn");

  // Define a URL da música
  if (musicaUrl) {
    backgroundMusic.src = musicaUrl;
  }

  var newMusicaUrl = document.body.getAttribute("data-musica-url");
  if (newMusicaUrl) {
    localStorage.setItem("musicaUrl", newMusicaUrl);
    if (backgroundMusic.src !== newMusicaUrl) {
      backgroundMusic.src = newMusicaUrl;
    }
  }

  // Define o volume programaticamente (por exemplo, 50%)
  backgroundMusic.volume = 0.3;

});
