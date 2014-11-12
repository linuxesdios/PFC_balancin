#include "Bluetooth.h"

extern char str_blue[40];
extern char str_aux[40];
#define MAX_BLUE    50
#define DEF_BLUE    1

void EnviarCR()
{
#ifdef DEF_BLUE
    U2TXREG = '\r';
    while (!U2STAbits.TRMT);
    U2TXREG = '\n';
    while (!U2STAbits.TRMT);
#endif
}

void enviar_datos_NOCR(char cadena[50], int longitud)
{
#ifdef DEF_BLUE
    unsigned char index;
    for (index = 0; index < longitud; index++)
    {
        U2TXREG = cadena[index];
        while (!U2STAbits.TRMT);
    }
#endif
}

void enviar_datos(char cadena[50], int longitud)
{
#ifdef DEF_BLUE
    enviar_datos_NOCR(cadena, longitud);
    EnviarCR();
#endif
}

void enviar_Udatos_NOCR(unsigned char cadena[50], int longitud)
{
#ifdef DEF_BLUE
    unsigned char index;
    for (index = 0; index < longitud; index++)
    {
        U2TXREG = cadena[index];
        while (!U2STAbits.TRMT);
    }
#endif
}

void enviar_Udatos(unsigned char cadena[50], int longitud)
{
#ifdef DEF_BLUE
    enviar_Udatos_NOCR(cadena, longitud);
    EnviarCR();
#endif
}


void enviar_valor(char nombre[], int valor)
{

    enviar_datos_NOCR(nombre, strlen(nombre));
    itoa(str_blue, valor, 10);
    enviar_datos(str_blue, strlen(str_blue));

}

void enviar_valor_NOCR(char nombre[], int valor)
{

    enviar_datos_NOCR(nombre, strlen(nombre));
    itoa(str_blue, valor, 10);
    enviar_datos_NOCR(str_blue, strlen(str_blue));

}

void enviar_mensaje(char nombre[])
{
    enviar_datos(nombre, strlen(nombre));
}

void enviar_mensaje_NOCR(char nombre[])
{
    enviar_datos_NOCR(nombre, strlen(nombre));
}

// Variables globales
char DatoRecibido[80];
int IndiceBluetooth;

// Funcion de interrupcion de recepcion de datos

void interrupcion _U2RXInterrupt(void)
{
StopInterrup3();

    //***********************ESTE CODIGO ES VALIDO PARA ENVIAR PARAMETROS DESDE PC ******************//
    int i;
    DatoRecibido[IndiceBluetooth] = U2RXREG; // Leemos el valor
    if (IndiceBluetooth < (MAX_BLUE - 1))IndiceBluetooth++;//cada dato qe nos entra le añadimos incrementando el incice

    if (DatoRecibido[IndiceBluetooth - 1] == 0x23) //almuadilla
    {
        //acabamos de recibir una trama completa con los parametros del pid
        IndiceBluetooth--;
        ProcesarCadenaPid(DatoRecibido);
        //la trama esta procesadara y con los parametros modificados.
        
        for (i = 0; i < MAX_BLUE; i++)DatoRecibido[i] = '\0';// Se borra la cadena completa
        IndiceBluetooth = 0;//se incializa la cadena indice
        enviar_mensaje("Fin de procesar cadena PID****************");

    }

    IFS1bits.U2RXIF = 0; // clear TX interrupt flag
    U2STAbits.OERR = 0;
    StartInterrup3();
}


// Funcion para procear los datos recibidos

void ProcesarCadenaPid(char *cadena) {
#ifdef DEF_BLUE
    int i = 0;
    int indice_i = 0;
    int x = 0;
    char aux_0[10] = {'\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0'};
    char aux_1[10] = {'\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0'};
    char aux_2[10] = {'\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0'};
    char aux_3[10] = {'\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0'};
    char aux_4[10] = {'\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0'};
    char aux_5[10] = {'\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0'};
    char aux_6[10] = {'\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0'};
    char aux_7[10] = {'\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0'};
    char aux_8[10] = {'\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0'};
    char aux_9[10] = {'\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0'};
    char aux_10[10] = {'\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0'};
    char aux_11[10] = {'\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0'};
    char aux_12[10] = {'\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0', '\0'};
    do {

        if (i > 0) {//asi eliminamos el dolar
            if (cadena[i] != 0x2c)//coma
            {
                if (x == 0)aux_0[indice_i] = cadena[i];
                if (x == 1)aux_1[indice_i] = cadena[i];
                if (x == 2)aux_2[indice_i] = cadena[i];
                if (x == 3)aux_3[indice_i] = cadena[i];
                if (x == 4)aux_4[indice_i] = cadena[i];
                if (x == 5)aux_5[indice_i] = cadena[i];
                if (x == 6)aux_6[indice_i] = cadena[i];
                if (x == 7)aux_7[indice_i] = cadena[i];
                if (x == 8)aux_8[indice_i] = cadena[i];
                if (x == 9)aux_9[indice_i] = cadena[i];
                if (x == 10)aux_10[indice_i] = cadena[i];
                if (x == 11)aux_11[indice_i] = cadena[i];
                if (x == 12)aux_12[indice_i] = cadena[i];
                indice_i++;
            } else {
                x++;
                indice_i = 0;
            }
        }
        i++;
    } while (cadena[i] != 0x23);

    //pasamos parametros aux a parametros globales
    int eje = atoi(aux_0);
    switch(eje)
    {
        case 1:
            enviar_mensaje("Recibido parar motores");
            act_motor=0;
            break;
        case 2:
            enviar_mensaje("Recibido arrancar motores");
            act_motor=1;
            break;
        case 3:
            enviar_mensaje("Recibido modificacion de parametros");
            Eeprom_WriteWord(2, atoi(aux_1));
            Eeprom_WriteWord(4, atoi(aux_2));
            Eeprom_WriteWord(6, atoi(aux_3));
            Eeprom_WriteWord(8, atoi(aux_4));
            Eeprom_WriteWord(10, atoi(aux_5));
            Eeprom_WriteWord(12, atoi(aux_6));
            Eeprom_WriteWord(14, atoi(aux_7));
            Eeprom_WriteWord(16, atoi(aux_8));
            Eeprom_WriteWord(18, atoi(aux_9));
            Eeprom_WriteWord(20, atoi(aux_10));
            Eeprom_WriteWord(22, atoi(aux_11));
            Eeprom_WriteWord(24, atoi(aux_12));
            Eeprom_WriteWord(0, 6969);
            reset();
            break;
      case 4:
          setpoint=atoi(aux_1);
            enviar_mensaje("Cambiado setpoint.");
            break;
        default:
            enviar_mensaje("Comando no reconocido.");
            break;
    }
#endif

}



void enviar_datos_int_NOCR(int cadena[50], int _longitud)
{
#ifdef DEF_BLUE
    unsigned char index;
    char aux[1];
    //    itoa(str_blue,_longitud,10);
    //    enviar_datos(str_blue,strlen(str_blue));

    for (index = 0; index < _longitud >> 1; index++)
    {
        aux[0] = cadena[index];
        U2TXREG = aux[0];
        while (!U2STAbits.TRMT);

        aux[0] = cadena[index] >> 8;

        U2TXREG = aux[0];
        while (!U2STAbits.TRMT);
    }
#endif
}
void plot1(int valor1)
{
        int encabezado[3];
        encabezado[0]=0xCDAB;
        encabezado[1]= 2*sizeof(int);
        encabezado[2]=valor1;
        int pktSize = 2 + 2 + (1*sizeof(int));
        enviar_datos_NOCR((char * )encabezado, pktSize);

}
void plot2(int valor1, int valor2)
{
        int encabezado[4];
        encabezado[0]=0xCDAB;
        encabezado[1]= 2*sizeof(int);
        encabezado[2]=valor1;
        encabezado[3]=valor2;
        int pktSize = 2 + 2 + (2*sizeof(int));
        enviar_datos_NOCR((char * )encabezado, pktSize);

}
void plot3(int valor1, int valor2,int valor3)
{
        int encabezado[5];
        encabezado[0]=0xCDAB;
        encabezado[1]= 3*sizeof(int);
        encabezado[2]=valor1;
        encabezado[3]=valor2;
        encabezado[4]=valor3;
        int pktSize = 2 + 2 + (3*sizeof(int));
        enviar_datos_NOCR((char * )encabezado, pktSize);
}
void plot4(int valor1, int valor2,int valor3,int valor4)
{
        int encabezado[6];
        encabezado[0]=0xCDAB;
        encabezado[1]= 4*sizeof(int);
        encabezado[2]=valor1;
        encabezado[3]=valor2;
        encabezado[4]=valor3;
        encabezado[5]=valor4;
        int pktSize = 2 + 2 + (4*sizeof(int));
        enviar_datos_NOCR((char * )encabezado, pktSize);

}