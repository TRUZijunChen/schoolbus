package com.schoolbus.client.api;

import com.schoolbus.client.api.*;
import com.schoolbus.client.model.*;

import org.apache.cxf.jaxrs.ext.multipart.Attachment;

import com.schoolbus.client.model.Inspection;
import com.schoolbus.client.model.SchoolBus;
import com.schoolbus.client.model.SchoolBusNote;

import java.util.List;

import java.io.InputStream;

import javax.ws.rs.core.Response;
import javax.ws.rs.core.SecurityContext;

@javax.annotation.Generated(value = "class com.quartech.codegen.FuseGenerator", date = "2016-12-12T18:43:27.997-08:00")
public interface SchoolbusesApiService {
      public Response inspectionsGet(Integer schoolbusId, SecurityContext securityContext);
      public Response schoolbusesSchoolbusIdGet(Integer schoolbusId, SecurityContext securityContext);
      public Response schoolbusesSchoolbusIdNotesGet(Integer schoolbusId, SecurityContext securityContext);
}
