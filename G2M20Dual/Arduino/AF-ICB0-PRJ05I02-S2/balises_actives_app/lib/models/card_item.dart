import 'package:balises_actives_app/models/model_routes.dart';
import 'package:flutter/material.dart';

class CardItem extends StatelessWidget {
  CardItem(this.route, this.value, this.callback, this.groupValue);
  final Routes route;
  int value, groupValue;
  Function callback;
  @override
  Widget build(BuildContext context) {
    return ListTile(
      onTap: () {
        callback(value);
      },
      title: Text(route.codeRoute),
      leading: Radio(
        value: value,
        groupValue: groupValue,
        onChanged: (int value) {
          callback(value);
        },
      ),
    );
  }
}
