using System;
using System.Linq;

public class DatosPartidaJugador {
	public int Puesto { get; set; }
	public int RoleAlcalde { get; set; }
	public int RoleBuscadorDeOro { get; set; }
	public int RoleCapataz { get; set; }
	public int RoleCapitan { get; set; }
	public int RoleColonizador { get; set; }
	public int RoleConstructor { get; set; }
	public int RoleMercader { get; set; }
	public int MonedasGanadas { get; set; }
	public int MonedasGanadasAcumuladasRole { get; set; }
	public int MonedasGastadas { get; set; }
	public int PVGanados { get; set; }
	public int EdificiosComprados { get; set; }
	public int EdificiosFabrica { get; set; }
	public int EdificiosLilasNormales { get; set; }
	public int EdificiosLilasGrandes { get; set; }
	public int PlantacionesCogidas { get; set; }
	public int CanterasCogidas { get; set; }
	public int PlantacionMaizCogido { get; set; }
	public int PlantacionAnilCogido { get; set; }
	public int PlantacionAzucarCogido { get; set; }
	public int PlantacionTabacoCogido { get; set; }
	public int PlantacionCafeCogido { get; set; }
	public int MaizProducido { get; set; }
	public int AnilProducido { get; set; }
	public int AzucarProducido { get; set; }
	public int TabacoProducido { get; set; }
	public int CafeProducido { get; set; }
	public int ColonosConseguidos { get; set; }
	public int ColonosSanJuan { get; set; }
	public int BarrilesVendidos { get; set; }
	public int SobreprecioVentas { get; set; }
	public int TableroEdificios { get; set; }
	public int TableroPlantaciones { get; set; }
	
	public DatosPartidaJugador() {
		limpiarVariables();
	}
	
	public void limpiarVariables() {
		Puesto = 0;
		RoleAlcalde = 0;
		RoleBuscadorDeOro = 0;
		RoleCapataz = 0;
		RoleCapitan = 0;
		RoleColonizador = 0;
		RoleConstructor = 0;
		RoleMercader = 0;
		MonedasGanadas = 0;
		MonedasGanadasAcumuladasRole = 0;
		MonedasGastadas = 0;
		PVGanados = 0;
		EdificiosComprados = 0;
		EdificiosFabrica = 0;
		EdificiosLilasNormales = 0;
		EdificiosLilasGrandes = 0;
		PlantacionesCogidas = 0;
		CanterasCogidas = 0;
		PlantacionMaizCogido = 0;
		PlantacionAnilCogido = 0;
		PlantacionAzucarCogido = 0;
		PlantacionTabacoCogido = 0;
		PlantacionCafeCogido = 0;
		MaizProducido = 0;
		AnilProducido = 0;
		AzucarProducido = 0;
		TabacoProducido = 0;
		CafeProducido = 0;
		ColonosConseguidos = 0;
		ColonosSanJuan = 0;
		BarrilesVendidos = 0;
		SobreprecioVentas = 0;
		TableroEdificios = 0;
		TableroPlantaciones = 0;
	}
}