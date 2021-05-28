class Routes {
  int id;
  String codeRoute;
  String descRoute;

  static Routes fromJson(Map<String, dynamic> json) {
    Routes routes = Routes();
    routes.id = json["id"];
    routes.codeRoute = json["codeRoute"];
    routes.descRoute = json["descRoute"];
    return routes;
  }
}
