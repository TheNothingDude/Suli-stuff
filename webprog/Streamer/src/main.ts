import "./style.css";

abstract class MediaContent {
  protected title: string = "";
  protected url: string = "";
  protected playCount: number = 0;

  constructor(cim: string, url: string) {
    if (cim == "" && url == "") return;
    this.title = cim;
    this.url = url;
  }
  public play() {
    this.playCount++;
  }
  abstract renderCard(index: number): string;

  get Title(): string {
    return this.title;
  }
  get Url(): string {
    return this.url;
  }
  get PlayCount() {
    return this.playCount;
  }
}

class Song extends MediaContent {
  protected artist!: string;
  constructor(cim: string, url: string, artist: string) {
    super(cim, url);
    this.artist = artist;
  }
  renderCard(index: number): string {
    return `
      <div class="card">
        <span class="card-badge">🎵 Song</span>
        <h4>${this.title}</h4>
        <p><small>Előadó: ${this.artist}</small></p>
        <p>Lejátszva: <b id="count-${index}">${this.playCount}</b> alkalommal</p>
        <button onclick="playMedia(${index})">▶️ Lejátszás</button>
      </div>
    `;
  }
}

class PodcastEpisode extends MediaContent {
  protected host!: string;
  constructor(cim: string, url: string, host: string) {
    super(cim, url);
    this.host = host;
  }
  renderCard(index: number): string {
    return `
      <div class="card">
        <span class="card-badge">🎵 Song</span>
        <h4>${this.title}</h4>
        <p><small>Előadó: ${this.host}</small></p>
        <p>Lejátszva: <b id="count-${index}">${this.playCount}</b> alkalommal</p>
        <button onclick="playMedia(${index})">▶️ Lejátszás</button>
      </div>
    `;
  }
}

class VideoContent extends MediaContent {
  protected resolution!: string;
  constructor(cim: string, url: string, resolution: string) {
    super(cim, url);
    this.resolution = resolution;
  }
  renderCard(index: number): string {
    return `
      <div class="card">
        <span class="card-badge">🎵 Song</span>
        <h4>${this.title}</h4>
        <p><small>Előadó: ${this.resolution}</small></p>
        <p>Lejátszva: <b id="count-${index}">${this.playCount}</b> alkalommal</p>
        <button onclick="playMedia(${index})">▶️ Lejátszás</button>
      </div>
    `;
  }
}

class Playlist {
  protected name!: string;
  public items: MediaContent[] = [];

  addMedia(media: MediaContent) {
    this.items.push(media);
  }
}

(window as any).playMedia = (index: number) => {
  l.items[index].play();
};
const l: Playlist = new Playlist();
const cont = document.getElementById("app");
let i = 0;
l.addMedia(new VideoContent("war bad", "https://youtube.com", "1080p"));
l.addMedia(new Song("Shape of netanyahu", "abs", "Ed Sheeran"));
l.addMedia(new PodcastEpisode("trumpf", "a", "john"));
const init = () => {
  if (cont) {
    cont.innerHTML = `<form action="">
        <label for="cim">Cim: </label>
        <input type="text" name="cim" id="cim" />
        <label for="url">url: </label>
        <input type="text" name="url" id="url" />
        <select name="type" id="type">
          <option value="song">Song</option>
          <option value="podcast">Podcast</option>
          <option value="vid">Video</option>
        </select>
        <label for="extra"></label>
        <input type="text" name="extra" id="extra" />
        <br />
        <button id="add">add</button>
      </form>`;
    l.items.forEach((e) => {
      cont.insertAdjacentHTML("beforeend", e.renderCard(i));
      i++;
    });
  }
};
init();
const but = document.getElementById("add");
but?.addEventListener("click", (e) => {
  try {
    e.preventDefault();
    const cimInput = document.getElementById("cim") as HTMLInputElement;
    const urlInput = document.getElementById("url") as HTMLInputElement;
    const typeSelect = document.getElementById("type") as HTMLSelectElement;
    const extraInput = document.getElementById("extra") as HTMLInputElement;

    let cim = cimInput.value;
    let url = urlInput.value;
    let type = typeSelect.value;
    let extra = extraInput.value;

    if (!cim || !url) return;
    let Media!: MediaContent;

    switch (type) {
      case "podcast":
        Media = new PodcastEpisode(cim, url, extra);
        break;
      case "song":
        Media = new Song(cim, url, extra);
        break;
      case "vid":
        Media = new VideoContent(cim, url, extra);
        break;
    }
    l.addMedia(Media);
    init();
    cimInput.value = "";
    urlInput.value = "";
    extraInput.value = "";
  } catch (error: any) {
    console.error(`${error.massage}`);
  }
});
