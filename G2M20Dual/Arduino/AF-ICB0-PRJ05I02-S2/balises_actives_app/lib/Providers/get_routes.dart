import 'dart:convert';
import 'package:http/http.dart' as http;
import 'package:balises_actives_app/models/model_routes.dart';

class API {
  Future<List<Routes>> getRoutes() async {
    var response =
        await http.get("http://g2team-001-site1.itempurl.com/api/routes");
    Iterable apiroutes = json.decode(response.body);
    print(apiroutes);
    return List<Routes>.from(apiroutes.map((model) => Routes.fromJson(model)));
  }
}
