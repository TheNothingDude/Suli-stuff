abstract class BaseConverter {
  public static systemName: string = "SI Metric";
  public static format(value: number, unit: string): string {
    return `${value} ${unit}`;
  }
}

abstract class DistanceConverter extends BaseConverter {
  public static kmToMeters(km: number): string {
    return super.format(km * 1000, "m");
  }
}

abstract class PrecisionDistanceConverter extends DistanceConverter {
  public static kmToMetersWithPrefix(km: number): string {
    return `${super.systemName} ${super.kmToMeters(km)}`;
  }
}

console.log(PrecisionDistanceConverter.kmToMetersWithPrefix(10));
