package com.schoolbus.client.api.impl;

import com.schoolbus.client.api.*;
import com.schoolbus.client.model.*;

import org.apache.cxf.jaxrs.ext.multipart.Attachment;

import com.schoolbus.client.model.Region;
import com.schoolbus.client.model.City;
import com.schoolbus.client.model.LocalArea;
import com.schoolbus.client.model.SchoolDistrict;

import java.util.List;

import java.io.InputStream;

import javax.enterprise.context.RequestScoped;
import javax.ws.rs.core.Response;
import javax.ws.rs.core.SecurityContext;

@RequestScoped
@javax.annotation.Generated(value = "class com.quartech.codegen.FuseGenerator", date = "2016-12-12T18:43:27.997-08:00")
public class RegionsApiServiceImpl implements RegionsApiService {
      @Override
      public Response regionsGet(SecurityContext securityContext) {
      // do some magic!
      return Response.ok().entity("magic!").build();
  }
      @Override
      public Response regionsRegionIdCitiesGet(Integer regionId, SecurityContext securityContext) {
      // do some magic!
      return Response.ok().entity("magic!").build();
  }
      @Override
      public Response regionsRegionIdGet(Integer regionId, SecurityContext securityContext) {
      // do some magic!
      return Response.ok().entity("magic!").build();
  }
      @Override
      public Response regionsRegionIdLocalareasGet(Integer regionId, SecurityContext securityContext) {
      // do some magic!
      return Response.ok().entity("magic!").build();
  }
      @Override
      public Response regionsRegionIdSchooldistrictsGet(Integer regionId, SecurityContext securityContext) {
      // do some magic!
      return Response.ok().entity("magic!").build();
  }
}
