interface IWeatherAPI {
  varos: string;
  homerseklet: number[];
  szel: { sebesseg: number; irany: string };
  paratartalom: string;
}

class Weather {
  public static readAPI({
    varos,
    homerseklet: [actual, ...elozoHomersekletek],
    szel,
    paratartalom,
  }: IWeatherAPI): string {
    const { sebesseg: szelSebesseg } = szel;
    return `${varos}: ${actual} Celsius, ${szelSebesseg} m/s`;
  }
  public static currectTemp({
    homerseklet: [current, ...rest],
  }: IWeatherAPI): number {
    return current;
  }

  public static avgTemp({ homerseklet }: IWeatherAPI): number {
    return (
      homerseklet.reduce((acc: number, current: number) => acc + current, 0) /
      homerseklet.length
    );
  }
}
const idojarasAdat = {
  varos: "Budapest",
  homerseklet: [22, 20, 19, 18], // 0. index az aktuális
  szel: {
    sebesseg: 14,
    irany: "ÉNY",
  },
  paratartalom: "55%",
};

console.log(Weather.readAPI(idojarasAdat));

const currentDiv = document.getElementById("actual");
const avgDiv = document.getElementById("avg");

currentDiv.innerText = `${Weather.currectTemp(idojarasAdat)} Celsius`;
avgDiv.innerText = `${Weather.avgTemp(idojarasAdat)} Celsius`;
