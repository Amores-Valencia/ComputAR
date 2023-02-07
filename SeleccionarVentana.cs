using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SeleccionarVentana : MonoBehaviour
{
    public GameObject VentanaPlaca;
    public GameObject VentanaMicro;
    public GameObject VentanaRam;
    public GameObject VentanaRom;
    public GameObject VentanaSecundaria;
    public GameObject VentanaPerifericos;
    public GameObject VentanaPuertos;

    Animation AVentanaPlaca;
    Animation AVentanaMicro;
    Animation AVentanaRam;
    Animation AVentanaRom;
    Animation AVentanaSecundaria;
    Animation AVentanaPerifericos;
    Animation AVentanaPuertos;

    bool VisibleVPlaca = false;
    bool VisibleVMicro = false;
    bool VisibleVRam = false;
    bool VisibleVRom = false;
    bool VisibleVSecundaria = false;
    bool VisibleVPerifericos = false;
    bool VisibleVPuertos = false;

    void Start()
    {
        AVentanaPlaca = VentanaPlaca.GetComponent<Animation>();
        AVentanaMicro = VentanaMicro.GetComponent<Animation>();
        AVentanaRam = VentanaRam.GetComponent<Animation>();
        AVentanaRom = VentanaRom.GetComponent<Animation>();
        AVentanaSecundaria = VentanaSecundaria.GetComponent<Animation>();
        AVentanaPerifericos = VentanaPerifericos.GetComponent<Animation>();
        AVentanaPuertos = VentanaPuertos.GetComponent<Animation>();
    }

    public void VentanaPlaPulsada()
    {
        if (VisibleVPlaca == false)
        {
            AVentanaPlaca["Placa"].speed = 1;
            AVentanaPlaca.Play();
            VisibleVPlaca = true;
        }
    }

    public void VentanaMicPulsada()
    {
        if (VisibleVMicro == false)
        {
            AVentanaMicro["Micro"].speed = 1;
            AVentanaMicro.Play();
            VisibleVMicro = true;
        }
    }

    public void VentanaRamPulsada()
    {
        if (VisibleVRam == false)
        {
            AVentanaRam["Ram"].speed = 1;
            AVentanaRam.Play();
            VisibleVRam = true;
        }
    }

    public void VentanaRomPulsada()
    {
        if (VisibleVRom == false)
        {
            AVentanaRom["Rom"].speed = 1;
            AVentanaRom.Play();
            VisibleVRom = true;
        }
    }

    public void VentanaSecPulsada()
    {
        if (VisibleVSecundaria == false)
        {
            AVentanaSecundaria["Secundaria"].speed = 1;
            AVentanaSecundaria.Play();
            VisibleVSecundaria = true;
        }
    }

    public void VentanaPerPulsada()
    {
        if (VisibleVPerifericos == false)
        {
            AVentanaPerifericos["Perifericos"].speed = 1;
            AVentanaPerifericos.Play();
            VisibleVPerifericos = true;
        }
    }

    public void VentanaPuePulsada()
    {
        if (VisibleVPuertos == false)
        {
            AVentanaPuertos["Puertos"].speed = 1;
            AVentanaPuertos.Play();
            VisibleVPuertos = true;
        }
    }

    public void VentanaNoPulsada()
    {
        string NombreBoton = EventSystem.current.currentSelectedGameObject.name;

        if (NombreBoton != "Placa" & VisibleVPlaca == true)
        {
            AVentanaPlaca["Placa"].speed = -1;
            AVentanaPlaca["Placa"].time = AVentanaPlaca["Placa"].length;
            AVentanaPlaca.Play();
            VisibleVPlaca = false;
        }

        if (NombreBoton != "Micro" & VisibleVMicro == true)
        {
            AVentanaMicro["Micro"].speed = -1;
            AVentanaMicro["Micro"].time = AVentanaMicro["Micro"].length;
            AVentanaMicro.Play();
            VisibleVMicro = false;
        }

        if (NombreBoton != "Ram" & VisibleVRam == true)
        {
            AVentanaRam["Ram"].speed = -1;
            AVentanaRam["Ram"].time = AVentanaRam["Ram"].length;
            AVentanaRam.Play();
            VisibleVRam = false;
        }

        if (NombreBoton != "Rom" & VisibleVRom == true)
        {
            AVentanaRom["Rom"].speed = -1;
            AVentanaRom["Rom"].time = AVentanaRom["Rom"].length;
            AVentanaRom.Play();
            VisibleVRom = false;
        }

        if (NombreBoton != "Secundaria" & VisibleVSecundaria == true)
        {
            AVentanaSecundaria["Secundaria"].speed = -1;
            AVentanaSecundaria["Secundaria"].time = AVentanaSecundaria["Secundaria"].length;
            AVentanaSecundaria.Play();
            VisibleVSecundaria = false;
        }

        if (NombreBoton != "Perifericos" & VisibleVPerifericos == true)
        {
            AVentanaPerifericos["Perifericos"].speed = -1;
            AVentanaPerifericos["Perifericos"].time = AVentanaPerifericos["Perifericos"].length;
            AVentanaPerifericos.Play();
            VisibleVPerifericos = false;
        }

        if (NombreBoton != "Puertos" & VisibleVPuertos == true)
        {
            AVentanaPuertos["Puertos"].speed = -1;
            AVentanaPuertos["Puertos"].time = AVentanaPuertos["Puertos"].length;
            AVentanaPuertos.Play();
            VisibleVPuertos = false;
        }
    }
}
