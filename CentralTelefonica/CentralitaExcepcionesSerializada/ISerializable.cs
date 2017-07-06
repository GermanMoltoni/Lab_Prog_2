interface ISerializable
{
    string RutaDeArchivo{ get;  set; }
    bool DeSerializarse();
    bool Serializarse();
}