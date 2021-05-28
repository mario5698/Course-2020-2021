import 'dart:async';
import 'dart:convert';

import 'package:balises_actives_app/models/card_item.dart';
import 'package:flutter/material.dart';
import 'package:balises_actives_app/Providers/get_routes.dart';
import 'package:balises_actives_app/models/model_routes.dart';
import 'package:flutter_bluetooth_serial/flutter_bluetooth_serial.dart';

import 'search_devices.dart';

class HomePage extends StatefulWidget {
  const HomePage({
    Key key,
  }) : super(key: key);

  @override
  _HomePageState createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> with TickerProviderStateMixin {
  BluetoothState _bluetoothState = BluetoothState.STATE_ON;
  String deviceSelected = "";
  API api = API();
  List<Routes> apiRoutes = List();
  int groupValue = 0;
  BluetoothDevice selectedDevice;

  @override
  void initState() {
    super.initState();
    _loadRoutes();

    // Get current state
    FlutterBluetoothSerial.instance.state.then((state) {
      setState(() {
        _bluetoothState = state;
      });
    });
  }

  Future _loadRoutes() async {
    apiRoutes = await api.getRoutes();
  }

  @override
  Widget build(BuildContext context) {
    //bool _bluetoothConnected = _bluetoothState.isEnabled;
    return Scaffold(
      appBar: buildAppBar(context),
      body: Container(
        child: ListView(
          children: <Widget>[
            SizedBox(
              height: 20,
            ),
            Divider(),
            Padding(
              padding: EdgeInsets.only(left: 30),
              child: Text("Device Connected : " + deviceSelected),
            ),
            Padding(
              padding: const EdgeInsets.only(top: 50, left: 10),
              child: Padding(
                padding: const EdgeInsets.symmetric(horizontal: 10),
                child: Row(
                  children: [
                    Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: <Widget>[
                        Text("Available Routes"),
                        Container(
                          width: 200,
                          height: 200,
                          color: Colors.amber,
                          child: ListView.builder(
                            padding: const EdgeInsets.only(top: 5, left: 5),
                            itemCount: apiRoutes.length,
                            itemBuilder: (BuildContext context, int index) =>
                                CardItem(
                              apiRoutes[index],
                              index,
                              callback,
                              groupValue,
                            ),
                          ),
                        ),
                      ],
                    ),
                    TextButton(
                      child: Text("Send Code"),
                      onPressed: () {
                        sendData();
                      },
                    ),
                  ],
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }

  void sendData() {
    print(selectedDevice.address);
    BluetoothConnection connection;
    BluetoothConnection.toAddress(selectedDevice.address).then((_connection) {
      connection = _connection;

      if (selectedDevice != null) {
        connection.output.add(ascii.encode(apiRoutes[groupValue].codeRoute));
        print(apiRoutes[groupValue].codeRoute);
      }
    });
  }

  void callback(int value) {
    groupValue = value;
    setState(() {});
  }

  AppBar buildAppBar(BuildContext context) {
    return AppBar(
      backgroundColor: Colors.amber,
      elevation: 6,
      actions: [
        TextButton(
          child: Text(
            "Conectar",
          ),
          onPressed: () async {
            selectedDevice = await Navigator.of(context).push(
              MaterialPageRoute(
                builder: (context) {
                  return BluetoothSearch(checkAvailability: false);
                },
              ),
            );

            if (selectedDevice != null) {
              print('Connect -> selected ' + selectedDevice.name);
              deviceSelected = selectedDevice.name;
              // _startChat(context, selectedDevice);
            } else {
              print('Connect -> no device selected');
            }
          },
        ),
        TextButton(
          child: Text("Desconectar"),
          onPressed: () {},
        ),
        TextButton(
          child: Text("Get Routes"),
          onPressed: () {
            setState(() {
              _loadRoutes();
            });
          },
        ),
      ],
    );
  }
}
