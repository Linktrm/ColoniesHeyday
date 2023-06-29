using System;
using System.Linq;

public class EstadisticasGlobales
{
	// TODO public File archivoDatos { get; set; }
	public String Apodo { get; set; }
	public String Avatar { get; set; }
	
	public int PartidasJugadas { get; set; }
	public int PartidasJugadas3J { get; set; }
	public int PartidasJugadas4J { get; set; }
	public int PartidasJugadas5J { get; set; }
	public int Victorias { get; set; }
	public int Derrotas { get; set; }
	public int MediaVictorias { get; set; }
	public int MediaDerrotas { get; set; }
	public int MediaPuestos3J { get; set; }
	public int MediaPuestos4J { get; set; }
	public int MediaPuestos5J { get; set; }
	public int MediaRoleAlcalde { get; set; }
	public int MediaRoleBuscadorDeOro { get; set; }
	public int MediaRoleCapataz { get; set; }
	public int MediaRoleCapitan { get; set; }
	public int MediaRoleColonizador { get; set; }
	public int MediaRoleConstructor { get; set; }
	public int MediaRoleMercader { get; set; }
	public int MediaMonedasGanadas { get; set; }
	public int MediaMonedasGanadasAcumuladasRole { get; set; }
	public int MediaMonedasGastadas { get; set; }
	public int MediaPVGanados { get; set; }
	public int MediaEdificiosComprados { get; set; }
	public int MediaEdificiosFabrica { get; set; }
	public int MediaEdificiosLilasNormales { get; set; }
	public int MediaEdificiosLilasGrandes { get; set; }
	public int MediaPlantacionesCogidas { get; set; }
	public int MediaCanterasCogidas { get; set; }
	public int MediaPlantacionMaizCogido { get; set; }
	public int MediaPlantacionAnilCogido { get; set; }
	public int MediaPlantacionAzucarCogido { get; set; }
	public int MediaPlantacionTabacoCogido { get; set; }
	public int MediaPlantacionCafeCogido { get; set; }
	public int MediaMaizProducido { get; set; }
	public int MediaAnilProducido { get; set; }
	public int MediaAzucarProducido { get; set; }
	public int MediaTabacoProducido { get; set; }
	public int MediaCafeProducido { get; set; }
	public int MediaColonosConseguidos { get; set; }
	public int MediaColonosSanJuan { get; set; }
	public int MediaBarrilesVendidos { get; set; }
	public int MediaSobreprecioVentas { get; set; }
	public int MediaTableroEdificios { get; set; }
	public int MediaTableroPlantaciones { get; set; }
	
	public EstadisticasGlobales(String nombre) {
		limpiarVariables();
		leerArchivoDatos();
	}
	
	public void limpiarVariables() {
		PartidasJugadas = 0;
		PartidasJugadas3J = 0;
		PartidasJugadas4J = 0;
		PartidasJugadas5J = 0;
		Victorias = 0;
		MediaDerrotas = 0;
		MediaVictorias = 0;
		Derrotas = 0;
		MediaPuestos3J = 0;
		MediaPuestos4J = 0;
		MediaPuestos5J = 0;
		MediaRoleAlcalde = 0;
		MediaRoleBuscadorDeOro = 0;
		MediaRoleCapataz = 0;
		MediaRoleCapitan = 0;
		MediaRoleColonizador = 0;
		MediaRoleConstructor = 0;
		MediaRoleMercader = 0;
		MediaMonedasGanadas = 0;
		MediaMonedasGanadasAcumuladasRole = 0;
		MediaMonedasGastadas = 0;
		MediaPVGanados = 0;
		MediaEdificiosComprados = 0;
		MediaEdificiosFabrica = 0;
		MediaEdificiosLilasNormales = 0;
		MediaEdificiosLilasGrandes = 0;
		MediaPlantacionesCogidas = 0;
		MediaCanterasCogidas = 0;
		MediaPlantacionMaizCogido = 0;
		MediaPlantacionAnilCogido = 0;
		MediaPlantacionAzucarCogido = 0;
		MediaPlantacionTabacoCogido = 0;
		MediaPlantacionCafeCogido = 0;
		MediaMaizProducido = 0;
		MediaAnilProducido = 0;
		MediaAzucarProducido = 0;
		MediaTabacoProducido = 0;
		MediaCafeProducido = 0;
		MediaColonosConseguidos = 0;
		MediaColonosSanJuan = 0;
		MediaBarrilesVendidos = 0;
		MediaSobreprecioVentas = 0;
		MediaTableroEdificios = 0;
		MediaTableroPlantaciones = 0;
	}
	
	public void leerArchivoDatos() {
		
		// TODO  Cargar el fichero del jugador dentro de File archivoDatos. Si no existe, crear uno nuevo.
		
	}
	
	public void guardarArchivoDatos() {
		
		// TODO guardar el valor de las variables en el archivo.
		
	}
}