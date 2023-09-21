//using System;

namespace es2__23_24.classePersona
{
	/*
	 * Creare una classe contenente i dati anagrafici di una persona:
	 * codice, cognome, nome,
	 * oltre a un'informazione booleana "registrato" che indica se la persona è stata sottoposta a un'approvazione o registrazione in generale.
	 * 
	 * Metodi:
	 * - registra
	 * - mostra
	 */
	class Persona
	{
		private string nome, cognome, codice;
		private bool registrato;

		public Persona()
		{
			nome = "nessun nome";
			cognome = "nessun cognome";
			codice = "nessun codice";
			registrato = false;
		}

		public Persona(string nome, string cognome, string codice, bool registrato = false)
		{
			if(!SetPersona(nome, cognome, codice, registrato))
			{
				this.nome = "inserimento non valido, [throw]";
				this.cognome = "inserimento non valido, [throw]";
				this.codice = "inserimento non valido, [throw]";
				this.registrato = false;
			}
		}

		public bool SetNome(string nome)
		{
			if(string.IsNullOrEmpty(nome)) return false;
			this.nome = nome;
			return true;
		}

		public bool SetCognome(string cognome)
		{
			if(string.IsNullOrEmpty(cognome)) return false;
			this.cognome = cognome;
			return true;
		}

		public bool SetCodice(string codice)
		{
			if(string.IsNullOrEmpty(codice)) return false;
			this.codice = codice;
			return true;
		}

		public bool SetRegistrato(bool registrato)
		{
			if(registrato) return Registra(); //se registrato è true, allora passa nel metodo registra, e ritorna true solo se la registrazione è valida, altrimenti c'è errore.
			this.registrato = false;
			return true; //se registrato è false, non c'è errore.
		}

		public bool SetPersona(string nome, string cognome, string codice, bool registrato = false)
		{
			return SetNome(nome) & SetCognome(cognome) & SetCodice(codice) & SetRegistrato(registrato);
		}

		public string GetNome()
		{
			return nome;
		}

		public string GetCognome()
		{
			return cognome;
		}

		public string GetCodice()
		{
			return codice;
		}

		public bool GetRegistrato()
		{
			return registrato;
		}

		public bool Registra()
		{
			registrato = true;
			return true;
		}

	}
}
